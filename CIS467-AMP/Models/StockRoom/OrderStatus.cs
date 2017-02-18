using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This class is for holding the possible Order Statuses
    /// Id - Id for this record
    /// Name - Name of Status (Such as Order placed, order received, order checked in, Order to be received)
    /// </summary>
    public class OrderStatus
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}