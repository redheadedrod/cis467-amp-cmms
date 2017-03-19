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
                .Include(s => s.LeadWorker)
            ;
            return View(workOrder);
        }

        private WorkOrderViewModel CreateViewModel(int? Id)
        {
            var workers = _context.Workers;
            var inventory = _context.AssetInventories;
            var status = _context.MaintenanceStatuses;
            var issues = _context.MaintenanceIssues;
            var plan = _context.JobPlans;
            int priority = 5;
            var viewModel = new WorkOrderViewModel()
            {
                Workers = workers,
                AssetInventories = inventory,
                MaintenanceStatuses = status,
                MaintenanceIssue = issues,
                JobPlan = plan,
                Priority = priority,
                Edit = false,
            };
            if (Id != null)
            {
                var workOrder = _context.MaintenanceWorkOrders.FirstOrDefault(x => x.Id == Id);
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
            return View(CreateViewModel(null));
        }

        public ActionResult EditWorkOrder(int? Id)
        {
            return View(CreateViewModel(Id));
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
            return RedirectToAction("Index", "Maintenance");
        }
    }
}
