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
    /// ManufacturerPart - Link to Part
    /// ManufacturerPartId - Link to Part - for forms
    /// OnHand - Number of parts onhand
    /// MinRequired - Minimum number of item that are required to have onhand
    /// Reserved - Number of items currently reserved
    /// Location - Location within stockroom
    /// </summary>
    public class StockRoomInventory
    {
        public int Id { get; set; }
        public string StockId { get; set; }
<<<<<<< HEAD
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
=======
        public ManufacturerVariant Variant { get; set; }
        public int VariantId { get; set; }
        public ManufacturerPart Part { get; set; }
        public int PartId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
        public int OnHand { get; set; }
        public int MinRequired { get; set; }
        public int Reserved { get; set; }
        public string Location { get; set; }
    }
}
