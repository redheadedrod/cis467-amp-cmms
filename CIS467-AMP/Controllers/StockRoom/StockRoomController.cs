using System.Data.Entity;
using System.Web.Mvc;
using System.Linq;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.ViewModels;
using CIS467_AMP.Models.StockRoom;
using Microsoft.Ajax.Utilities;
using CIS467_AMP.ViewModels.StockRoom;

namespace CIS467_AMP.Controllers.StockRoom
{

    /**
     * Author: Jason Bensel
     * Default controller to serve /Views/StockRoom/Index.cshtml
     */
    public class StockRoomController : Controller
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

        /// <summary>
        /// Retrieves Inventory.cshtml
        /// </summary>
        /// <returns>List of current inventory</returns>
        public ActionResult Inventory()
        {
            //Include allows the variant and part object to be loaded with the stockroom inventory
            var inventory = _context.StockroomInventories.Include(i => i.Variant)
                                                         .Include(p => p.Part);   
            return View(inventory);
        }

        /// <summary>
        /// Grabs all of the data required for an order and constructs defaults
        /// </summary>
        /// <param name="inventory">Current inventory item selected for order</param>
        /// <returns>viewmodel with all associated data required</returns>
        public ActionResult OrderRequest(string StockId, int PartId)
        {
            var orderRequest = new OrderRequestViewModel();
            var suppliers = _context.StockroomSupplierPartIndices.Where(x => x.StockRoom.StockId == StockId).Include(s => s.Supplier);
            var order = new Order();
            var status = new OrderStatus();
            var part = new Part();

            part = _context.Parts.FirstOrDefault(x => x.Id == PartId);
            
            //set defaults
            order.OrderNumber = "TEST999";
            order.OrderPlaced = new System.DateTime();
            order.OrderExpected = new System.DateTime();
            order.StatusLastUpDate = new System.DateTime();
            order.OrderApproved = true;

            //Load status id into order
            status.Id = 0;
            order.OrderStatus = status;

            //Insert a default order into db
            _context.StockroomOrders.Add(order);

            //Query the for the current entry to retrieve the ID of the Order (This is not ideal)
            order = _context.StockroomOrders.FirstOrDefault(x => x.OrderPlaced == order.OrderPlaced);

            //Load suppleirs into viewmodel
            orderRequest.Suppliers = suppliers;
            //Load part into viewmodel
            orderRequest.Part = part;
            //Load order defaults into view model
            orderRequest.Order = order;


            //Send data to view for 
            return View(orderRequest);
        }


        ////NOT DONE YET
        //public ActionResult OrderRequest()
        //{
        //    var orderRequest = _context.StockroomOrders;
        //    return View(orderRequest);
        //}

        [HttpPost]
        public ActionResult CreateOrder(Order order)
        {
            _context.StockroomOrders.Add(order);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}