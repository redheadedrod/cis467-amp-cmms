using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This is the index of Suppliers to parts. More than one supplier could supply the parts
    /// Id - Id of record
    /// StockRoomId - Id of part listed in stockroominventory
    /// Supplier - Link to supplier in library
    /// Price - Price of item
    /// DateTimeOfLastPrice - Last time price was updated
    /// DateTimePriceGoodUntil - Price is good until this date (If known. Normally only applies to contracted items
    /// PartNumber - Suppliers Part/Item number. Can be Alpha/Numeric. Can also be different from manufacturer part number
    /// </summary>
    public class SupplierPartIndex
    {
        public int Id { get; set; }
        public StockroomInventory StockRoom { get; set; }
        public Supplier Supplier { get; set; }
        public float Price { get; set; }
        public DateTime DateTimeOfLastPrice { get; set; }
        public DateTime DateTimePriceGoodUntil { get; set; }
        public string PartNumber { get; set; }
    }
}