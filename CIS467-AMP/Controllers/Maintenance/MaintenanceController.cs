using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS467_AMP.Models;

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
            return View();
        }

        public ActionResult CurrentWorkOrder()
        {
            var workOrders = _context.MaintenanceWorkOrders;
            return View(workOrders);
        }
    }
}
