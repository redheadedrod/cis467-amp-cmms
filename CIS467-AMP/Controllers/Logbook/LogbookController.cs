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
            var status = _context.LogbookGeneralStatuses;
            var index = _context.AssetInventories;
            var workers = _context.Workers;
            // Make amends for not having Name field at first. To be removed when db is fixed
            foreach (Worker worker in workers)
            {
                if (worker.Name == null)
                {
                    worker.Name = worker.LastName + ", " + worker.FirstName;
                }
            }


            var viewModel = new EntryViewModel
            {
                LogbookGeneralStatuses = status,
                AssetInventories = index,
                Workers = workers
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(LogbookGeneral logbookGeneral)
        {
            logbookGeneral.EnteredDateTime = DateTime.Now;
            _context.LogbookGeneral.Add(logbookGeneral);
            _context.SaveChanges();
            return RedirectToAction("Index", "Logbook");
        }

        public ActionResult Maintenance()
        {
            var logbook = _context.LogbookWorkOrders
                .Include(a => a.AssetInventory)
                .Include(o => o.WorkOrder)
                .Include(w => w.Worker)
                .Include(s => s.WorkOrder.MaintenanceStatus)
                ;
            return View(logbook);
        }

        public ActionResult StockroomOrders()
        {
            var logbook = _context.LogbookStockroomOrders
                .Include(a => a.AssetInventory)
                .Include(o => o.Order)
                .Include(w => w.Worker)
                .Include(s => s.Order.OrderStatus)
                ;

            return View(logbook);
        }

        public ActionResult StockroomOrderRequests()
        {
            var logbook = _context.LogbookStockroomRequests
                .Include(a => a.AssetInventory)
                .Include(o => o.Request)
                .Include(w => w.Worker)
                .Include(s => s.Request.StockroomRequestStatus)
                ;

            return View(logbook);
        }


    }
}