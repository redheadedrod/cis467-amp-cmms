using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// This class will hold asset types
    /// 
    /// Additional classes that will link to this to define type totally include:
    /// variant - will be a list of variations (could be size, updates or special purpose items)
    /// jobplan - will list job plans if available
    /// partslist - will list parts lists for this type - parts lists will access the variants list and not this list directly
    /// </summary>
    public class AssetType
    {
        public int AssetTypeID { get; set; }
        public string AssetName { get; set; }
        public int ManID { get; set; } // Links to manufacturer field
        public string PartNumber { get; set; } // Manufacturers part number for asset (can be number, numbers or combination)
    }
}