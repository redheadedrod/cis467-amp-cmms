using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class StockRoomOrderNote
    {
        public int Id { get; set; }
        public StockRoomOrder StockRoomOrder { get; set; }
        public int StockRoomOrderId { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public DateTime WhenEntered { get; set; }
        [StringLength(80)]
        public string Note { get; set; }
    }
}