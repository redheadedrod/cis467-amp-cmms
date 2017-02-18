using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This class is to allow notes to be added to an order that has been placed to keep track of contacts with supplier
    /// Id - Record Id
    /// OrderId - Id of order this is attached to
    /// Worker - Worker that entered note
    /// WhenEntered - DateTime of entry
    /// Note - Note its self
    /// </summary>
    public class OrderNote
    {
        public int Id { get; set; }
        public Order OrderId { get; set; }
        public Worker WorkerId { get; set; }
        public DateTime WhenEntered { get; set; }
        public string Note { get; set; }
    }
}