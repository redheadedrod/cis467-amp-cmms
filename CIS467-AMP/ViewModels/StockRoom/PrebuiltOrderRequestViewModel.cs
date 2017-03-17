using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.StockRoom;
using System.Web.Mvc;
using CIS467_AMP.ViewModels.StockRoom;

namespace CIS467_AMP.ViewModels.StockRoom
{
    public class PrebuiltOrderRequestViewModel
    {
        public IEnumerable<StockRoomSupplier> StockRoomSuppliers { get; set; }
        public double Cost { get; set; }
        public StockRoomInventory CurrentInventory { get; set; }
        public Order Order { get; set; }
        public ManufacturerPart Part { get; set; }
    }
}
