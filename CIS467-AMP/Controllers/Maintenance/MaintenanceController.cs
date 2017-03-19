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
                OldStatus = null

            };
            if (Id != null)
            {
                var workOrder = _context.MaintenanceWorkOrders.FirstOrDefault(x => x.Id == Id);
                if (workOrder != null)
                {
                    viewModel.MaintenanceWorkOrder = workOrder;
                    viewModel.Edit = true;
                    viewModel.Priority = workOrder.Priority;
                    viewModel.OldStatus = workOrder.MaintenanceStatusId;
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
            if (viewModel.OldStatus != viewModel.MaintenanceWorkOrder.MaintenanceStatusId)
            {
                viewModel.MaintenanceWorkOrder.LastStatusDateTime = DateTime.Now;
            }
            if (viewModel.MaintenanceWorkOrder.CreatedDateTime < SqlDateTime.MinValue.Value)
                viewModel.MaintenanceWorkOrder.CreatedDateTime = SqlDateTime.MinValue.Value;
            if (viewModel.MaintenanceWorkOrder.LastStatusDateTime < SqlDateTime.MinValue.Value)
                viewModel.MaintenanceWorkOrder.LastStatusDateTime = SqlDateTime.MinValue.Value;

            _context.Entry(viewModel.MaintenanceWorkOrder).State= EntityState.Modified;
            _context.SaveChanges(); 
            return RedirectToAction("Index", "Maintenance");
        }
    }
}
