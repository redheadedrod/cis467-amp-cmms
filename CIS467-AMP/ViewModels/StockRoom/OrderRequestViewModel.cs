using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.StockRoom;


namespace CIS467_AMP.ViewModels.StockRoom
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderRequestViewModel
    {
        public List<RequestSuppliersViewModel> RequestSupplier { get; set; }
        public List<StockRoomSupplier> Suppliers { get; set; }
    }
}
