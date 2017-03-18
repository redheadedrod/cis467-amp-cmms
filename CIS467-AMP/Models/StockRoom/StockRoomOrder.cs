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
    /// StockRoomSupplier - Link to supplier order placed with
    /// StockRoomSupplierId - Link to supplier order placed with - for forms
    /// MaintenanceWorkOrder - Link to Work order this order is attached to (If applicable, null if not) 
    /// MaintenanceWorkOrderId - Link to Work order this order is attached to (If applicable, null if not) - for forms
    /// StockRoomSupplierContact - Link to Contact person or department order was placed through
    /// StockRoomSupplierContactId - Link to Contact person or department order was placed through - for forms
    /// OrderPlaced - When order was placed
    /// OrderExpected - When order is expected
    /// StatusLastUpDate - Last time the status was updated/changed
    /// StockRoomOrderStatus - order Status
    /// StockRoomOrderStatusId - order Status - for forms
    /// OrderApproved - All orders must be approved before they can be placed (Also allows for automatic ordering for future expansion)
    ///      For auto generated work orders the stockroom person can approve the work order if all items are inventory items. (Insures auto orders don't get made unreasonably)
    ///      Manually entered work orders are automatically approved if all order lines are inventory items. 
    ///      For orders including special order items all inventory item lines will automatically be approved and the special order lines need to be approved
    ///      by supervisor.
    ///      
    /// Note: We should be able to remove items from the order which will allow them to get placed on a different order. Thus allowing inventory items to be approved right away
    /// only requiring supervisor approval of orders including special order items. Allowing but not requiring this action.
    /// </summary>
    public class StockRoomOrder
    {
        public int Id { get; set; } 
        public string OrderNumber { get; set; }
        public StockRoomSupplier StockRoomSupplier { get; set; }
        public int StockRoomSupplierId { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int? MaintenanceWorkOrderId { get; set; }
        public StockRoomSupplierContact StockRoomSupplierContact { get; set; }
        public int StockRoomSupplierContactId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderExpected { get; set; }
        public DateTime StatusLastUpDate { get; set; }
        public StockRoomOrderStatus StockRoomOrderStatus { get; set; }
        public int StockRoomOrderStatusId { get; set; }
        public bool OrderApproved { get; set; }
    }
}
