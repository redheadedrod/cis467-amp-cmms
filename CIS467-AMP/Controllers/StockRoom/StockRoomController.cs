using System.Data.Entity;
using System.Web.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Shared;
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

        // stub called from logbook
        public ActionResult Order(int id)
        {
            return View();
        }

        //Stub for use with logbook
        public ActionResult Request(int id)
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
            var inventory = _context.StockRoomInventories.Include(i => i.ManufacturerPart);   
            return View(inventory);
        }
        /*
        /// <summary>
        /// Grabs all of the data required for an order and constructs defaults
        /// </summary>
        /// <param name="inventory">Current inventory item selected for order</param>
        /// <returns>viewmodel with all associated data required</returns>
        public ActionResult PrebuiltOrderRequest(string StockId, int? PartId)
        {

            var currentInventory = _context.StockRoomInventories.FirstOrDefault(x => x.StockId == StockId);
            var partsIndices = _context.StockroomSupplierPartIndexes.Where(x => x.StockRoomInventory.StockId == StockId).Include(x => x.Supplier).ToList();
            var part = _context.Parts.FirstOrDefault(x => x.Id == PartId);

            Random random = new Random();

            //Generate random string for order number
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var orderNumber = new string(
                Enumerable.Repeat(chars, 20)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            //Iterate through Parts Indices to grab supplier objects
            var suppliers = new List<StockRoomSupplier>();
            var cost = new Double();
            foreach (var supplier in partsIndices)
            {
                suppliers.Add(supplier.Supplier);
                cost = supplier.Price;
            }

            //Create generic order
            var order = new StockRoomOrder()
            {
                OrderNumber = orderNumber
            };

            //Append all objects to order request form
            var orderRequest = new PrebuiltOrderRequestViewModel()
            {
                CurrentInventory = currentInventory,
                Suppliers = suppliers,
                Part = part,
                Order = order,
                Cost = cost
            };

            //Send data to view for 
            return View(orderRequest);
           
        }

        public ActionResult NewOrderRequest()
        {
            var parts = _context.Parts;
            return View();

        }


        [HttpPost]
        public ActionResult CreatePreBuiltOrder(FormCollection collection)
        {
            DateTime createdDate = DateTime.Now;
         
            //Used for dummy orders
            DateTime expectedDate = createdDate.AddDays(5);
            var stockId = collection[0];
            var partName = collection[2];
            var partNumber = collection[3];
            var units = Convert.ToInt32(collection[4]);
            var supplierId = Convert.ToInt32(collection[5]);

            Order order = new Order
            {
                OrderNumber = collection[1],
                OrderPlaced = createdDate,
                OrderExpected = expectedDate,
                StatusLastUpDate = createdDate,
                OrderApproved = true,
                OrderStatus = _context.StockroomOrderStatuses.FirstOrDefault(x => x.Id == 0),
                Supplier = _context.StockroomSuppliers.FirstOrDefault(x => x.Id == supplierId),
                SupplierContact = _context.StockroomSupplierContacts.FirstOrDefault(x => x.Supplier.Id == supplierId),
                WorkOrder = null
            };
            ManufacturerPart part = _context.Parts.FirstOrDefault(x => x.Number == partNumber);
          

            _context.StockroomOrders.Add(order);
            _context.SaveChanges();

            OrderLine orderLine = new OrderLine
            {
                NumberOfItemsOrdered = units,
                Order = _context.StockroomOrders.FirstOrDefault(x => x.OrderNumber == order.OrderNumber),
                SupplierPartIndex = _context.StockroomSupplierPartIndices.FirstOrDefault(x => x.StockRoomInventory.StockId == stockId)
            };
            //orderLine.SupplierPartIndex.StockRoom = _context.StockroomInventories.FirstOrDefault(x => x.StockId == stockId);
            //orderLine.SupplierPartIndex.StockRoom.Variant = _context.Variants.FirstOrDefault(x => x.Id == 0);
            //orderLine.SupplierPartIndex.StockRoom.Variant = _context.StockroomInventories

            _context.StockroomOrderLines.Add(orderLine);
            _context.SaveChanges();

            return RedirectToAction("Inventory");
        }

        [HttpPost]
        public ActionResult CreateOrder(Order order)
        {
            _context.StockroomOrders.Add(order);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        } */
    }
}
