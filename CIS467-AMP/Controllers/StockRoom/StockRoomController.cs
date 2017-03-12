using System.Data.Entity;
using System.Web.Mvc;
using CIS467_AMP.Models;
using CIS467_AMP.Models.StockRoom;
using Microsoft.Ajax.Utilities;

namespace CIS467_AMP.Controllers.StockRoom
{

    /**
     * Author: Jason Bensel
     * Default controller to serve /Views/StockRoom/Index.cshtml
     */
    public class StockRoomController : System.Web.Mvc.Controller
    {
        //Disposable object allowing for data querying.
        private ApplicationDbContext _context;

        public StockRoomController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: StockRoom/Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Inventory()
        {
            var inventory = _context.StockroomInventories;   
            return View(inventory);
        }

        
        //NOT DONE YET
        public ActionResult OrderRequest()
        {
            var orderRequest = _context.StockroomOrders;
            return View(orderRequest);
        }

        [HttpPost]
        public ActionResult CreateOrder(Order order)
        {
            _context.StockroomOrders.Add(order);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        } 
    }
}