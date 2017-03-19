using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.ViewModels.Maintenance;

namespace CIS467_AMP.Controllers.Maintenance
{
    public class MaintenanceController : Controller
    {

        //Disposable object allowing for data querying.
        private ApplicationDbContext _context;

        public MaintenanceController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Maintenance
        public ActionResult Index()
        {
            var workOrder = _context.MaintenanceWorkOrders
                .Include(a => a.AssetInventory)
                .Include(w => w.Creator)
                .Include(s => s.MaintenanceStatus)
                .Include(l => l.LeadWorker)
            ;
            return View(workOrder);
        }

        private WorkOrderViewModel CreateViewModel(int? id, string message)
        {
            var workers = _context.Workers;
            var inventory = _context.AssetInventories;
            var status = _context.MaintenanceStatuses;
            var issues = _context.MaintenanceIssues;
            var plan = _context.JobPlans;
            int priority = 5;
            var viewModel = new WorkOrderViewModel()
            {
                Message = message,
                Workers = workers,
                AssetInventories = inventory,
                MaintenanceStatuses = status,
                MaintenanceIssue = issues,
                JobPlan = plan,
                Priority = priority,
                Edit = false
                
            };
            if (id != null)
            {
                var workOrder = _context.MaintenanceWorkOrders.FirstOrDefault(x => x.Id == id);
                if (workOrder != null)
                {
                    viewModel.MaintenanceWorkOrder = workOrder;
                    viewModel.Edit = true;
                    viewModel.Priority = workOrder.Priority;
                }
            }
            return (viewModel);
        }

        public ActionResult NewWorkOrder()
        {
            return View(CreateViewModel(null, ""));
        }

        public ActionResult EditWorkOrder(int? id, string message)
        {
            return View(CreateViewModel(id, message));
        }

        [HttpPost]
        public ActionResult Create(MaintenanceWorkOrder workOrder)
        {
            workOrder.CreatedDateTime = DateTime.Now;
            workOrder.LastStatusDateTime = DateTime.Now;
            workOrder.MaintenanceStatusId = 0;
            _context.MaintenanceWorkOrders.Add(workOrder);
            _context.SaveChanges(); 
            return RedirectToAction("Index", "Maintenance");
        }

        [HttpPost]
        public ActionResult Edit(WorkOrderViewModel viewModel)
        {
            if (Request.Form["time"] != null)
            {
                System.Diagnostics.Debug.WriteLine("Time");
                //WorkTime(viewModel.MaintenanceWorkOrder.Id);
                return WorkTime(viewModel.MaintenanceWorkOrder.Id);
            }

            else if (Request.Form["plan"] != null)
            { 
                System.Diagnostics.Debug.WriteLine("Plan");
                return JobPlan(viewModel.MaintenanceWorkOrder.Id);
            }
        else

        {
                System.Diagnostics.Debug.WriteLine("Save");
                var workOrder = _context.MaintenanceWorkOrders.Single(w => w.Id == viewModel.MaintenanceWorkOrder.Id);
                if (workOrder.MaintenanceStatusId != viewModel.MaintenanceWorkOrder.MaintenanceStatusId)
                {
                    workOrder.LastStatusDateTime = DateTime.Now;
                    workOrder.MaintenanceStatusId = viewModel.MaintenanceWorkOrder.MaintenanceStatusId;
                }
                else
                {
                    if (viewModel.MaintenanceWorkOrder.LastStatusDateTime < SqlDateTime.MinValue.Value)
                        viewModel.MaintenanceWorkOrder.LastStatusDateTime = SqlDateTime.MinValue.Value;
                }
                workOrder.AssetInventoryId = viewModel.MaintenanceWorkOrder.AssetInventoryId;
                if (viewModel.MaintenanceWorkOrder.CreatedDateTime < SqlDateTime.MinValue.Value)
                {
                    viewModel.MaintenanceWorkOrder.CreatedDateTime = SqlDateTime.MinValue.Value;
                }
                else
                {
                    workOrder.CreatedDateTime = viewModel.MaintenanceWorkOrder.CreatedDateTime;
                }
                workOrder.CreatorId = viewModel.MaintenanceWorkOrder.CreatorId;
                workOrder.JobPlanId = viewModel.MaintenanceWorkOrder.JobPlanId;
                workOrder.LeadWorkerId = viewModel.MaintenanceWorkOrder.LeadWorkerId;
                workOrder.MaintenanceIssueId = viewModel.MaintenanceWorkOrder.MaintenanceIssueId;
                workOrder.LongDesc = viewModel.MaintenanceWorkOrder.LongDesc;
                workOrder.ShortDesc = viewModel.MaintenanceWorkOrder.ShortDesc;
                workOrder.Priority = viewModel.MaintenanceWorkOrder.Priority;
                workOrder.SupervisorId = viewModel.MaintenanceWorkOrder.SupervisorId;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Maintenance");
        }

        public ActionResult WorkTime(int id)
        {
            var workers = _context.Workers.ToList();
            var workOrder = _context.MaintenanceWorkOrders;
            var workTimes = _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == id);
            var viewModel = new WorkTimeViewModel()
            {
                MaintenanceWorkOrder = workOrder,
                MaintenanceWorkOrderWorkTimes = workTimes,
                Worker = workers

            };
            return View("WorkTime",viewModel);
        }

        [HttpPost]
        public ActionResult AddTime(MaintenanceWorkOrderWorkTime time)
        {
            if (time.StartTime < SqlDateTime.MinValue.Value)
                time.StartTime = SqlDateTime.MinValue.Value;
            _context.MaintenanceWorkOrderWorkTime.Add(time);
            _context.SaveChanges();
            return WorkTime(time.MaintenanceWorkOrderId);
        }

        public ActionResult JobPlan(int id)
        {
            var workOrder = _context.MaintenanceWorkOrders.SingleOrDefault(wo => wo.Id == id);
            if (workOrder == null)
            {
                return Index();
            }
            /*if (workOrder.JobPlanId == null)
            {
                return EditWorkOrder(id, "No Work Plan found!");
            }*/
            var jobPlan = _context.JobPlans.SingleOrDefault(w => w.Id == workOrder.JobPlanId);
            /*if (jobPlan == null)
            {
                return EditWorkOrder(id, "No Work Plan found!");
            }*/
            var jobPlanDocument = _context.JobPlanDocuments.SingleOrDefault(d => d.JobPlanId == jobPlan.Id);
            /*if (jobPlanDocument == null)
            {
                return EditWorkOrder(id, "No Work Plan Document found!");
            }*/
            var manufacturerParts = _context.ManufacturerParts.ToList();
            var jobPlanParts = _context.JobPlanParts.Where(p => p.JobPlanId == jobPlan.Id);

            List<ManufacturerPart> parts = new List<ManufacturerPart>(); 
            List<int> partIds = new List<int>();

            foreach (JobPlanPart item in jobPlanParts)
            {
                partIds.Add(item.ManufacturerPartId);
            }
            foreach (ManufacturerPart item in manufacturerParts)
            {
                if (partIds.Find(x => x.Equals(item.Id)) != 0)
                {
                    parts.Add(item);
                }
            }
            var viewModel = new JobPlanViewModel()
            {
                JobPlan = jobPlan,
                JobPlanDocument = jobPlanDocument,

            };
            if (parts.Any())
                viewModel.ManufacturerParts = parts;
            return View("JobPlan",viewModel);
        }
        [HttpPost]
        public ActionResult PartsRequest()
        {
            return View();
        }
    }


}
