using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Maintenance;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// Actual Order to restock components or for special orders
    /// Id - Id for this order
    /// OrderNumber - OrderNumber from Supplier (Once given) Can be alpha numeric
    /// SupplierId - Id of supplier order placed with
    /// WorkOrderId - Work order number this order is attached to (If applicable)
    /// SupplierContactId - Contact number of person or department order was placed through
    /// OrderPlaced - When order was placed
    /// OrderExpected - When order is expected
    /// StatusLastUpDate - Last time the status was updated/changed
    /// OrderStatusId - order Status
    /// OrderApproved - All orders must be approved before they can be placed (Also allows for automatic ordering for future expansion) 
    /// </summary>
    public class Order
    {
        public int Id { get; set; } 
        public string OrderNumber { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public MaintenanceWorkOrder WorkOrder { get; set; }
        public int WorkOrderId { get; set; }
        public SupplierContact SupplierContact { get; set; }
        public int SupplierContactId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderExpected { get; set; }
        public DateTime StatusLastUpDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
        public bool OrderApproved { get; set; }
    }
}