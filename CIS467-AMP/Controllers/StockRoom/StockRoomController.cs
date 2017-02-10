using System.Web.Mvc;

namespace CIS467_AMP.Controllers.StockRoom
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