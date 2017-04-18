using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CIS467_AMP.Models;
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
            var context = new IdentityDbContext();
            var users = context.Users.ToList(); 
            List<string> nameList = new List<string>();
            foreach (var user in users)
            {
                nameList.Add(user.Email);
            }
            HomeViewModel viewModel = new HomeViewModel()
            {
                Users = nameList
            };
            return View(viewModel);
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}
