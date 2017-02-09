using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS467_AMP.Areas.StockRoom.Controller
{

    /**
     * Author: Jason Bensel
     * Default controller to serve /Views/StockRoom/Index.cshtml
     */
    public class StockRoomController : System.Web.Mvc.Controller
    {
        // GET: StockRoom/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}