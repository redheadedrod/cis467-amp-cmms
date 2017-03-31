using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// Orderline for inventory items
    /// This class is one line on an order so it is the actual part or item number being ordered. Can be unlimited number
    /// The Order number is initialized as null and will be attached to an order when one is created
    /// Id - Record number
    /// StockRoomOrder - Order this line is related to. If null then needs to be ordered yet
    /// StockRoomOrderId - Order this line is related to. If null then needs to be ordered yet - for forms
    /// StockRoomSupplierPartIndex - link to supplier index for part ordered (Also has supplier information)
    /// StockRoomSupplierPartIndexId - link to supplier index for part ordered (Also has supplier information) - for forms
    /// NumerOfItemsOrdered - number of this items on order
    /// Approved - Only used for auto generated. Defaults true if manually entered and false if Auto generated. Worker or supervisor can approve this line if false
    ///            When all order lines are true then the form will automatically go to approved. If form is approved then all order lines will be as well.
    /// </summary>
    public class StockRoomOrderLine
    {
        public int Id { get; set; }
        public StockRoomOrder StockRoomOrder { get; set; }
        public int? StockRoomOrderId { get; set; }
        public StockRoomSupplierPartIndex StockRoomSupplierPartIndex { get; set; }
        public int StockRoomSupplierPartIndexId { get; set; }

        [Range(0, 999)]
        public int NumberOfItemsOrdered { get; set; }
        public bool Approved { get; set; }
    }
}