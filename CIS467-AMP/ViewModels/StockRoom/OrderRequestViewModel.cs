using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.StockRoom;

namespace CIS467_AMP.ViewModels.StockRoom
{
    public class OrderRequestViewModel
    {
<<<<<<< HEAD
        public IQueryable<StockRoomSupplierPartIndex> Suppliers { get; set; }
        public StockRoomOrder Order { get; set; }
        //public ManufacturerPart Part { get; set; }
=======
        public IQueryable<SupplierPartIndex> Suppliers { get; set; }
        public Order Order { get; set; }
        public ManufacturerPart Part { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    }
}
