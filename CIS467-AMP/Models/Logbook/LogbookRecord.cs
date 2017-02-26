using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.Logbook
{
    /// <summary>
    /// This class is the actual record for the logbook
    /// Id - record ID 
    /// AssetId - ID of asset (Will need to figure out way to have generic assets)
    /// EnteredDateTime - Time entry was entered
    /// WorkerId - Worker that entered the logbook entry
    /// StatusId - ID of the status we associate with this entry
    /// TypeID - Type of entry for this entry
    /// Entry - Entry text for the record
    /// </summary>
    public class LogbookRecord
    {
        public int Id { get; set; }
        public AssetInventory AssetInventory { get; set; }
        public DateTime EnteredDateTime { get; set; }
        public Worker Worker { get; set; }
        public LogbookStatus LogbookStatus { get; set; }
        public LogbookType LogbookType { get; set; }
        public string Entry { get; set; }
    }
}