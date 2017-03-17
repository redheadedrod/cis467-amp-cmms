using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary> // Needs updating
    /// This is the stockroom inventory listing
    /// Id - record id
    /// StockID - Stockroom ID used within stockroom. Can be any Alpha Numeric combo
    /// Variant - Id of asset type if this is a complete item. (Example - a whole pump)
    /// Part - Id of part if item is a part of an asset type
    /// OnHand - Number of parts onhand
    /// MinRequired - Minimum number of item that are required to have onhand
    /// Reserved - Number of items currently reserved
    /// Location - Location within stockroom
    /// </summary>
    public class SpecialOrderList
    {
        public int Id { get; set; }
        public ManufacturerVariant Variant { get; set; }
        public int VariantId { get; set; }
        public ManufacturerPart Part { get; set; }
        public int PartId { get; set; }
    }
}
