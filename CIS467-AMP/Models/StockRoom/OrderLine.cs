using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This class is one line on an order so it is the actual part or item number being ordered. Can be unlimited number
    /// Id - Record number
    /// OrderId - Order this line is related to
    /// PartId - Supplier part Id of item being ordered
    /// NumerOfItemsOrdered - number of this items on order
    /// </summary>
    public class OrderLine
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public SupplierPartIndex SupplierPartIndex { get; set; }
        public int NumberOfItemsOrdered { get; set; }
    }
}