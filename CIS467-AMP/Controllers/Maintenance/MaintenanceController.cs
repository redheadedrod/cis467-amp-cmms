using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
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
                Priority = priority

            };
            if (Id != null)
            {
                viewModel.Priority = 3;
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
            /*logbookGeneral.EnteredDateTime = DateTime.Now;
            _context.LogbookGeneral.Add(logbookGeneral);
            _context.SaveChanges(); */
            return RedirectToAction("Index", "Maintenance");
        }

        [HttpPost]
        public ActionResult Edit(MaintenanceWorkOrder workOrder)
        {
            /*logbookGeneral.EnteredDateTime = DateTime.Now;
            _context.LogbookGeneral.Add(logbookGeneral);
            _context.SaveChanges(); */
            return RedirectToAction("Index", "Maintenance");
        }
    }
}
