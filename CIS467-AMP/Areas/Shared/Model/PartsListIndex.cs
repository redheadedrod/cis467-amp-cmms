using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// Parts list index - indexes parts to a particular variant
    /// 
    /// PartListID - Id for entry
    /// partID - ID of part
    /// VariantID - ID of asset Variant
    /// </summary>
    public class PartsListIndex
    {
        public int PartsListID { get; set; }
        public int PartID { get; set; }
        public int VariantID { get; set; }
    }
}