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
using CIS467_AMP.Controllers.Maintenance;

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

        // stub called from logbook - This needs to pull up an order request by ID
        public ActionResult Order(int id)
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

        /// <summary>
        /// Queries all order requests
        /// Allows for selection of requests to be ordered
        /// </summary>
        /// <returns></returns>
        public ActionResult PartRequest()
        {
            var suppliers = _context.StockRoomSuppliers.ToList();
            var requests = _context.StockroomRequestLines.Where(x => x.StockRoomRequest.StockRoomRequestStatusId == 0).Include(x => x.ManufacturerPart).ToList();
            var indexes = _context.StockroomSupplierPartIndexes;
            var requestSuppliers = new List<RequestSuppliersViewModel>();
            foreach(var request in requests)
            {
                RequestSuppliersViewModel rs = new RequestSuppliersViewModel();
                var supplierId = indexes.FirstOrDefault(x => x.ManufacturerPartId == request.ManufacturerPartId).StockRoomSupplierId;
                rs.Supplier = _context.StockRoomSuppliers.FirstOrDefault(x => x.Id == supplierId);
                rs.Request = request;

                requestSuppliers.Add(rs); 
                
            }
            PartRequestViewModel viewModel = new PartRequestViewModel()
            {
                Suppliers = suppliers,
                RequestSupplier = requestSuppliers
            };
            return View(viewModel);
        }

        /// <summary>
        /// Creates orders and all associated order lines
        /// </summary>
        /// <param name="collection">chosen request lines to order</param>
        /// <returns>returns to orderrequest</returns>
        [HttpPost]
        public ActionResult CreateOrder(FormCollection collection)
        {
            var count = collection.Count;
            var supplier = collection["Supplier"];
            var requestLineIds = new List<int>();
            for(int i = 0; i < count -1; i++)
            {
                var requestLineId = collection[i];
                if(requestLineId.Contains("true"))
                {
                    requestLineIds.Add(Convert.ToInt32(collection.Keys[i]));
                }
            }

            foreach(int id in requestLineIds)
            {
                var requestLine = _context.StockroomRequestLines.FirstOrDefault(x => x.Id == id);
                var partRequest = _context.StockRoomRequests.FirstOrDefault(x => x.Id == requestLine.StockRoomRequestId);
                partRequest.StockRoomRequestStatusId = 2; 
                _context.SaveChanges();
            }
            var orderNumber = getOrderNumber();

            DateTime createdDate = DateTime.Now;

            //Used for dummy orders
            DateTime expectedDate = createdDate.AddDays(5);

            var supplierId = _context.StockRoomSuppliers.FirstOrDefault(x => x.Name == supplier).Id;
            var suplierContactId = _context.StockroomSupplierContacts.FirstOrDefault(x => x.StockRoomSupplierId == supplierId).Id;
            StockRoomOrder order = new StockRoomOrder()
            {
                OrderNumber = orderNumber,
                StockRoomSupplierId = supplierId,
                StockRoomSupplierContactId = suplierContactId,
                OrderPlaced = createdDate,
                OrderExpected = expectedDate,
                StatusLastUpDate = createdDate,
                StockRoomOrderStatusId = 0,
                OrderApproved = true
            };

            _context.StockroomOrders.Add(order);
            _context.SaveChanges();

            var requestLines = new List<StockRoomRequestLine>();
            foreach(var requestlineId in requestLineIds)
            {
                var line = _context.StockroomRequestLines.FirstOrDefault(x => x.Id == requestlineId);
                var orderId = _context.StockroomOrders.FirstOrDefault(x => x.OrderNumber == orderNumber).Id;
                var indexId = +_context.StockroomSupplierPartIndexes.FirstOrDefault(x => x.ManufacturerPartId == line.ManufacturerPartId).Id;
                StockRoomOrderLine orderLine = new StockRoomOrderLine()
                {
                    StockRoomOrderId = orderId,
                    StockRoomSupplierPartIndexId = indexId,
                    NumberOfItemsOrdered = line.Number,
                    Approved = true
                };
                _context.StockroomOrderLines.Add(orderLine);
            }
            _context.SaveChanges();

            return RedirectToAction("PartRequest");
        }

        public ActionResult LowOrderRequest()
        {
            var inventory = _context.StockRoomInventories.Where(x => x.OnHand < x.MinRequired || x.OnHand - x.Reserved < x.MinRequired).Include(x => x.ManufacturerPart);

            return View(inventory);
        }
        
        public ActionResult CreateLowOrder(FormCollection collection)
        {

            var orderNumber = getOrderNumber();

            DateTime createdDate = DateTime.Now;

            //Used for dummy orders
            DateTime expectedDate = createdDate.AddDays(5);

            StockRoomOrder order = new StockRoomOrder()
            {
                OrderNumber = orderNumber,

            };
            return RedirectToAction("LowOrderRequest");
        }

        public ActionResult OrderRequest()
        {
            var inventory = _context.StockRoomInventories;

            var viewModel = new OrderRequestViewModel()
            {
                Inventory = inventory
            };
            return View(viewModel);
        }

        public ActionResult CreateNewOrder(FormCollection collection)
        {
            var orderNumber = getOrderNumber();
            DateTime createdDate = DateTime.Now;
            //Used for dummy orders
            DateTime expectedDate = createdDate.AddDays(5);
            var stockRoomId = Convert.ToInt32(collection["Inv.StockId"]);
            var quantityOrdered = collection["Line.NumberOfItemsOrdered"];

            var stockId = _context.StockRoomInventories.FirstOrDefault(x => x.Id == stockRoomId).StockId;
            var partNumber = _context.StockRoomInventories.FirstOrDefault(x => x.StockId == stockId).ManufacturerPartId;
            var supplierId = _context.StockroomSupplierPartIndexes.FirstOrDefault(x => x.ManufacturerPartId == partNumber).StockRoomSupplierId;
            var contact = _context.StockroomSupplierContacts.FirstOrDefault(x => x.StockRoomSupplierId == supplierId).Id;
            var order = new StockRoomOrder()
            {
                OrderNumber = orderNumber,
                StockRoomSupplierId = supplierId,
                StockRoomSupplierContactId = contact,
                OrderPlaced = createdDate,
                OrderExpected = expectedDate,
                StatusLastUpDate = createdDate,
                StockRoomOrderStatusId = 0,
                OrderApproved = true
            };

            _context.StockroomOrders.Add(order);
            _context.SaveChanges();


            var orderId = _context.StockroomOrders.FirstOrDefault(x => x.OrderNumber == orderNumber).Id;
            var manPartId = _context.StockRoomInventories.FirstOrDefault(x => x.StockId == stockId).ManufacturerPartId;
            var indexId = _context.StockroomSupplierPartIndexes.FirstOrDefault(x => x.ManufacturerPartId == manPartId).Id;
            var line = new StockRoomOrderLine()
            {
                StockRoomOrderId = orderId,
                StockRoomSupplierPartIndexId = indexId,
                NumberOfItemsOrdered = Convert.ToInt32(quantityOrdered),
                Approved = true

            };

            _context.StockroomOrderLines.Add(line);
            _context.SaveChanges();

            return RedirectToAction("OrderRequest");
        }

        private string getOrderNumber()
        {
            //Generate random string for order number
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var orderNumber = new string(
                Enumerable.Repeat(chars, 20)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return orderNumber;
        }

    }
}
