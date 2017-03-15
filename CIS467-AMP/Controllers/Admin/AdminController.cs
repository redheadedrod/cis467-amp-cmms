using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS467_AMP.Models;

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
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        //Not finished using temp model until data is in db
        public ActionResult PendingWorkOrders()
        {
            var workOrders = _context.MaintenanceWorkOrders;
            return View(workOrders);
        }
    }
}
