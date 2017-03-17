using CIS467_AMP.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Logbook
{
    /// <summary>
    /// This class is the Base model for logbooks. Extend this class for actual models
    /// Id - record ID 
    /// AssetId - ID of asset (Will need to figure out way to have generic assets)
    /// EnteredDateTime - Time entry was entered
    /// WorkerId - Worker that entered the logbook entry
    /// StatusId - ID of the status we associate with this entry
    /// TypeID - Type of entry for this entry
    /// Entry - Entry text for the record
    /// </summary>
    public class LogbookGeneral
    {
        public int Id { get; set; }
        public AssetInventory AssetInventory { get; set; }
        public int AssetInventoryId { get; set; }
        public DateTime EnteredDateTime { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public string Entry { get; set; }
        public LogbookGeneralStatus LogbookGeneralStatus { get; set; }
        public int LogbookGeneralStatusId { get; set; }
    }
}
