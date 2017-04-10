using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.StockRoom
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestSuppliersViewModel
    {
        public StockRoomSupplier Supplier { get; set; }
        public StockRoomRequestLine Request { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int Quantity { get; set; }
    }
}
