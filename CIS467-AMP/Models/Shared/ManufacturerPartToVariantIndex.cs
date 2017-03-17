using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class allows us to index a variant as a part to another variant. 
    /// All Main assets and their parts will be listed as different variants with the parts related to 
    /// the main asset via this index table. 
    /// The AssetInventory will only list the main assets that have been installed.
    /// This will also allow a part to be associated with more than one main asset as well.
    /// 
    /// ManufacturerVariant - Link to the variant that is a part 
    /// ManufacturerVariantId - Link to the variant that is a part - For forms
    /// ManufacturerParentVariant - The Main asset this is a part for
    /// ManufacturerParentVariantId - The Main asset this is a part for - for forms
    /// </summary>
    public class ManufacturerPartToVariantIndex
    {
        public ManufacturerVariant ManufacturerVariant { get; set; }
        public int ManufacturerVariantId { get; set; }
        public ManufacturerVariant ManufacturerParentVariant { get; set; }
        public int ManufacturerParentVariantId { get; set; }
    }
}