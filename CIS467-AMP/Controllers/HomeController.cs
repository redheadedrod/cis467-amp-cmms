using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Admin;
using CIS467_AMP.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CIS467_AMP.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [AllowAnonymous]  // allows anonymous users access to home page
        public ActionResult Index()
        {
            var systemNews = _context.SystemNews
                .OrderByDescending(o => o.EnteredDateTime);
            return View(systemNews);
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}
