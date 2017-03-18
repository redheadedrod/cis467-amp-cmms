using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This is the index of Suppliers to parts. More than one supplier could supply the parts
    /// Id - Id of record
    /// ManufacturerPart - Link to manufacturer part
    /// ManufacturerPartId - Link to manufacturer part - for forms
    /// StockRoomSupplier - Link to supplier
    /// StockRoomSupplierId - Link to supplier
    /// Price - Price of item
    /// DateTimeOfLastPrice - Last time price was updated
    /// DateTimePriceGoodUntil - Price is good until this date (If known. Normally only applies to contracted items
    /// PartNumber - Suppliers Part/Item number. Can be Alpha/Numeric. Can also be different from manufacturer part number
    /// </summary>
    public class StockRoomSupplierPartIndex
    {
        public int Id { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public StockRoomSupplier StockRoomSupplier { get; set; }
        public int StockRoomSupplierId { get; set; }
        public float Price { get; set; }
        public DateTime DateTimeOfLastPrice { get; set; }
        public DateTime DateTimePriceGoodUntil { get; set; }
        public string PartNumber { get; set; }
    }
}
