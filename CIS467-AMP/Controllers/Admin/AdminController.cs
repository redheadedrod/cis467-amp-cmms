using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Admin;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.ViewModels.Admin;

namespace CIS467_AMP.Controllers.Admin
{
    public class AdminController : Controller
    {
        //Disposable object allowing for data querying.
        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult NewsEntry()
        {
            var viewModel = new NewsEntryViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewsEntryViewModel newsEntry)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewsEntryViewModel
                {
                    SystemNews = newsEntry.SystemNews
                };
                return View("NewsEntry", viewModel);
            }
            SystemNews systemNews = new SystemNews()
            {
                EnteredDateTime = DateTime.Now,
                Entry = newsEntry.SystemNews.Entry
            };
            _context.SystemNews.Add(systemNews);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult StockroomOrderRequests()

        {
            var requests = _context.StockRoomRequests
                    .Include(w => w.Worker)
                    .Include(o => o.MaintenanceWorkOrder)
                    .Include(s => s.StockRoomRequestStatus)
                    .OrderByDescending(ob => ob.Requested)
                    .ToList()
                    ;
            return View(requests);
        }
        public ActionResult Maintenance()
        { 
            var workOrder = _context.MaintenanceWorkOrders
                        .Include(w => w.Creator)
                        .Include(s => s.MaintenanceStatus)
                        .OrderByDescending(ob => ob.LastStatusDateTime)
                        .ToList()
                        ;  
            return View(workOrder);
        }

        public ActionResult StockroomOrders()
        {
            var orders = _context.StockroomOrders
           .Include(a => a.StockRoomSupplier)
           .Include(s => s.StockRoomOrderStatus)
           .OrderByDescending(ob => ob.StatusLastUpDate)
           .ToList()
           ;
            return View(orders);
        }



    }
}
