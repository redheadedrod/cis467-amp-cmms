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
    /// Id - record Id
    /// ManufacturerVariant - Link to the variant that is a part 
    /// ManufacturerVariantId - Link to the variant that is a part - For forms
    /// ManufacturerPartParent - The Main asset this is a part for
    /// ManufacturerParentParentId - The Main asset this is a part for - for forms
    /// </summary>
    public class ManufacturerPartParentIndex
    {
        public int Id { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public ManufacturerPart ManufacturerPartParent { get; set; }
        public int ManufacturerPartParentId { get; set; }
    }
}