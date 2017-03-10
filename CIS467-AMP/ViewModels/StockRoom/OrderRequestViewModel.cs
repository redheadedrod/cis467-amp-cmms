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
        public IQueryable<SupplierPartIndex> Suppliers { get; set; }
        public Order Order { get; set; }
        public Part Part { get; set; }
    }
}