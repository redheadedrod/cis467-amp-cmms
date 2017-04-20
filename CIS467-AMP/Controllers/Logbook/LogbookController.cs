using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.Logbook;
using CIS467_AMP.ViewModels.Logbook;

namespace CIS467_AMP.Controllers.Logbook
{
    public class LogbookController : Controller
    {
        private ApplicationDbContext _context;

        public LogbookController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Logbook
        public ActionResult Index()
        {
            var logbook = _context.LogbookGeneral
                .Include(a => a.AssetInventory)
                .Include(w => w.Worker)
                .Include(s => s.LogbookGeneralStatus)
                ;
            return View(logbook); 

        }

        public ActionResult Entry()
        {
            var status = _context.LogbookGeneralStatuses.ToList();
            var inventory = _context.AssetInventories.ToList();
            var workers = _context.Workers.ToList();
            var worker = workers
                    .SingleOrDefault(w => w.EmailAddress == User.Identity.Name)
            ;
            var viewModel = new EntryViewModel
            {
                Workers = workers,
                LogbookGeneralStatuses = status,
                AssetInventories = inventory,
            };
            if (worker != null)
            {
                viewModel.WorkerId = worker.Id;
            }
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntryViewModel dataModel)
        {
            var workers = _context.Workers.ToList();
            if (!ModelState.IsValid)
            {
                var status = _context.LogbookGeneralStatuses.ToList();
                var inventory = _context.AssetInventories.ToList();

                var worker = workers
                    .SingleOrDefault(w => w.EmailAddress == User.Identity.Name)
                ;
                var viewModel = new EntryViewModel
                {
                    Workers = workers,
                    LogbookGeneralStatuses = status,
                    AssetInventories = inventory
                };
                if (worker != null)
                {
                    viewModel.WorkerId = worker.Id;
                }

                return View("Entry", viewModel);
            }
            dataModel.LogbookGeneral.EnteredDateTime = DateTime.Now;
            if (dataModel.WorkerId != null)
                dataModel.LogbookGeneral.Worker = workers.Single(w => w.Id == dataModel.WorkerId); 
            _context.LogbookGeneral.Add(dataModel.LogbookGeneral);
            _context.SaveChanges();
            return RedirectToAction("Index", "Logbook");
        }

        public ActionResult Maintenance()
        {
            var logbook = _context.MaintenanceWorkOrders
                .Include(w => w.Creator)
                .Include(s => s.MaintenanceStatus)
                ;
            return View(logbook);
        }

        public ActionResult StockroomOrders()
        {
            var logbook = _context.StockroomOrders
                .Include(a => a.StockRoomSupplier)
                .Include(s => s.StockRoomOrderStatus)
                ;

            return View(logbook);
        }

        public ActionResult StockroomOrderRequests()
        {
            var logbook = _context.StockRoomRequests
                .Include(w => w.Worker)
                .Include(o => o.MaintenanceWorkOrder)
                .Include(s => s.StockRoomRequestStatus)
                ;

            return View(logbook);
        }


    }
}
