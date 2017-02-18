using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS467_AMP.Controllers.Logbook
{
    public class LogbookController : Controller
    {
        // GET: Logbook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult General()
        {
            return View();
        }

        public ActionResult GeneralEntry()
        {
            return View();
        }

        public ActionResult Maintenance()
        {
            return View();
        }

        public ActionResult Stockroom()
        {
            return View();
        }

    }
}