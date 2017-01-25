using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Map index listing
    /// 
    /// MapID - id of entry
    /// Name - name of location - building if onsite but could be a specific address
    /// Parent - 0 if this is the starting point otherwise will point to the location it is related to 
    ///          (If house was starting location and this entry was bathroom the parent would be house)
    ///          (If refering to bathroom sink then bathroom would be parent which would have house as parent etc..)
    ///          (Allows to build a drop down menu with proper associations)
    /// * All following are optional and will be able to be set to a default
    /// Address - Address of asset
    /// City - city of home office
    /// Region - State or region of asset
    /// Country - Country of asset
    /// PostalCode - Postal code of asset
    /// </summary>
    public class Map
    {
        public int MapID { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}