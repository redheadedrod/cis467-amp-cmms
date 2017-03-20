using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Logbook;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.Logbook
{
    public class EntryViewModel
    {
        public IEnumerable<Worker> Workers { get; set; }
        public IEnumerable<LogbookGeneralStatus> LogbookGeneralStatuses { get; set; }
        public IEnumerable<AssetInventory> AssetInventories { get; set; }
        public LogbookGeneral LogbookGeneral { get; set; }
    }
}