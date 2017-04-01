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


            var viewModel = new EntryViewModel
            {
                LogbookGeneralStatuses = status,
                AssetInventories = inventory,
                Workers = workers
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogbookGeneral logbookGeneral)
        {
            if (!ModelState.IsValid)
            {
                var status = _context.LogbookGeneralStatuses.ToList();
                var inventory = _context.AssetInventories.ToList();
                var workers = _context.Workers.ToList();
                var viewModel = new EntryViewModel
                {
                    LogbookGeneralStatuses = status,
                    AssetInventories = inventory,
                    Workers = workers
                };
                return View("Entry", viewModel);
            }
            logbookGeneral.EnteredDateTime = DateTime.Now;
            _context.LogbookGeneral.Add(logbookGeneral);
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
