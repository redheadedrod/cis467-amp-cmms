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
        public IEnumerable<Supplier> Suppliers { get; set; }
        public double Cost { get; set; }
        public StockroomInventory CurrentInventory { get; set; }
        public Order Order { get; set; }
        public Part Part { get; set; }
    }
}