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
    /// RequestId - Id of the request this is a line for
    /// StockroomId - If in inventory this will be the part number from inventory (When accepted it will reserve these parts)
    /// Number - Number of this item to order
    /// SupplierId - Suggested supplier to get part from
    /// SupplierPartId - Part number from supplier if on list
    /// Description - Text for describing part and for inserting part number etc if not already entered into system
    /// </summary>
    public class RequestLine
    {
        public int Id { get; set; }
        public Request Request { get; set; }
        public int RequestId { get; set; }
        public StockroomInventory StockroomInventory { get; set; }
        public int StockroomInventoryId { get; set; }
        public int Number { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public SupplierPartIndex SupplierPart { get; set; }
        public int SupplierPartId { get; set; }
        public string Description { get; set; }
    }
}