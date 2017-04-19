using CIS467_AMP.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Admin
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
    public class SystemNews
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yy H:mm}")]
        public DateTime EnteredDateTime { get; set; }

        public Worker Worker { get; set; }
        public int WorkerId { get; set; }

        [Required(ErrorMessage = "The Entry field can not be blank!")]
        [StringLength(1024, ErrorMessage = "Maximum length is {1}!")]
        public string Entry { get; set; }

    }
}
