using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary> 
    /// Orderline for special order items (Close clone of Inventory order items)
    /// This class is one line on an order so it is the actual part or item number being ordered. Can be unlimited number
    /// The Order number is initialized as null and will be attached to an order when one is created
    /// Id - Record number
    /// StockRoomOrder - Order this line is related to. If null then needs to be ordered yet
    /// StockRoomOrderId - Order this line is related to. If null then needs to be ordered yet - for forms
    /// StockRoomSupplierPartIndex - link to supplier index for part ordered (Also has supplier information)
    /// StockRoomSupplierPartIndexId - link to supplier index for part ordered (Also has supplier information) - for forms
    /// NumerOfItemsOrdered - number of this items on order
    /// Approved - Special order items must always be approved by a supervisor before being ordered. Main order form can only be approved when all order lines are approved.
    /// </summary>
    public class StockRoomSpecialOrderLine
    {
        public int Id { get; set; }
        public StockRoomOrder StockRoomOrder { get; set; }
        public int? StockRoomOrderId { get; set; }
        public StockRoomSupplierPartIndex StockRoomSupplierPartIndex { get; set; }
        public int StockRoomSupplierPartIndexId { get; set; }
        public int NumberOfItemsOrdered { get; set; }
        public bool Approved { get; set; }
    }
}
