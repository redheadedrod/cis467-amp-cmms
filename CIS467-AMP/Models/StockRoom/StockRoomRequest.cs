using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This is an order request to get parts - Supports Special order items as well although they should be on a seperate request than
    /// those that are in inventory 
    /// Id - Record Id
    /// WorkerId - Worker that is requesting parts - For work order generated requests will be the lead worker on the order
    /// WorkOrderId - Id of the work order this is related to if it is related to one
    /// AssetId - If in inventory it will be the stockroom inventoryId
    /// Requested - DateTime order request was entered
    /// Required - Date order is required
    /// Approval - sets to false if any of the Request lines are special order items which will require supervisor approval.
    ///            If Item is in stockroom inventory then supervisor approval is not required.
    /// </summary>
    public class StockRoomRequest
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
<<<<<<< HEAD:CIS467-AMP/Models/StockRoom/StockRoomRequest.cs
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
=======
        public MaintenanceWorkOrder WorkOrder { get; set; }
        public int WorkOrderId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a:CIS467-AMP/Models/StockRoom/Request.cs
        public AssetInventory AssetInventory { get; set; }
        public int AssetInventoryId { get; set; }
        public DateTime Requested { get; set; }
        public DateTime Required { get; set; }
        public bool Approval { get; set; }
        public StockRoomRequestStatus StockRoomRequestStatus { get; set; }
        public int StockRoomRequestStatusId { get; set; }
    }
}