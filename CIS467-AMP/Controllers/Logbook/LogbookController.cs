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
    }
}