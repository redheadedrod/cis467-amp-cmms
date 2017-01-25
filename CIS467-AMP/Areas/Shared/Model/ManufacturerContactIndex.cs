using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{

    /// <summary>
    /// Class is used to create an index of contacts related to specific manufacturer. 
    /// This supports multiple contacts per manufacturer.
    /// 
    /// ID is the Id for each entry
    /// ManID is the Manufacturer ID
    /// ManContactID is the ID of a contact. 
    /// </summary>
    public class ManufacturerContactIndex
    {
        public int ID { get; set; }
        public int ManID { get; set; } 
        public int ManContactID { get; set; }
    }
}