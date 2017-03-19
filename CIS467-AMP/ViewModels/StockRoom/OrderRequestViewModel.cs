using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CIS467_AMP.Models.StockRoom;

namespace CIS467_AMP.ViewModels.StockRoom
{
    public class OrderRequestViewModel
    {
        public StockRoomOrder Order { get; set; }
        public IEnumerable<StockRoomInventory> Inventory { get; set; }
        public StockRoomInventory Inv { get; set; }
        public StockRoomOrderLine Line { get; set; }
    }
}