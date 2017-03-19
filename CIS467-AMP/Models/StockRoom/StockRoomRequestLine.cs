using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This is the order request line - one item per line
    /// Id - Record ID
    /// StockRoomRequestId - Id of the request this is a line for
    /// ManufacturerPart - Link to Manufacturer part 
    /// ManufacturerPartId - Link to Manufacturer part - for forms
    /// Number - Number of this item to order
    /// Description - Text for describing part and for inserting part number etc if not already entered into system
    /// </summary>
    public class StockRoomRequestLine
    {
        public int Id { get; set; }
        public StockRoomRequest StockRoomRequest { get; set; }
        public int StockRoomRequestId { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
    }
}
