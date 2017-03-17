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
    /// AssetInventory - link to asset
    /// AssetInventoryId - link to asset - for forms
    /// EnteredDateTime - Time entry was entered
    /// Worker - Link to Worker that entered the logbook entry
    /// WorkerId - Link to Worker that entered the logbook entry - for forms (probably not needed since will be entered automatically)
    /// Entry - Entry text for the record
    /// LogbookGeneralStatus - Status that we are logging
    /// LogbookGeneralStatusId - Status that we are logging - for forms

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
