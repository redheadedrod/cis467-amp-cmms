using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
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
    public class StockroomInventory
    {
        public int Id { get; set; }
        public string StockId { get; set; }
        public Variant Variant { get; set; }
        public int VariantId { get; set; }
        public Part Part { get; set; }
        public int PartId { get; set; }
        public int OnHand { get; set; }
        public int MinRequired { get; set; }
        public int Reserved { get; set; }
        public string Location { get; set; }
    }
}