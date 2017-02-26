namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorStockroomModels : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SupplierPartIndexes", name: "StockRoomId_Id", newName: "StockRoom_Id");
            RenameColumn(table: "dbo.SupplierPartIndexes", name: "SupplierId_Id", newName: "Supplier_Id");
            RenameColumn(table: "dbo.OrderNotes", name: "OrderId_Id", newName: "Order_Id");
            RenameColumn(table: "dbo.OrderNotes", name: "WorkerId_Id", newName: "Worker_Id");
            RenameColumn(table: "dbo.Requests", name: "AssetId_Id", newName: "Asset_Id");
            RenameColumn(table: "dbo.Requests", name: "WorkerId_Id", newName: "Worker_Id");
            RenameColumn(table: "dbo.Requests", name: "WorkOrderId_Id", newName: "WorkOrder_Id");
            RenameColumn(table: "dbo.RequestLines", name: "RequestId_Id", newName: "Request_Id");
            RenameColumn(table: "dbo.RequestLines", name: "StockroomId_Id", newName: "Stockroom_Id");
            RenameColumn(table: "dbo.RequestLines", name: "SupplierId_Id", newName: "Supplier_Id");
            RenameColumn(table: "dbo.RequestLines", name: "SupplierPartId_Id", newName: "SupplierPart_Id");
            RenameIndex(table: "dbo.SupplierPartIndexes", name: "IX_StockRoomId_Id", newName: "IX_StockRoom_Id");
            RenameIndex(table: "dbo.SupplierPartIndexes", name: "IX_SupplierId_Id", newName: "IX_Supplier_Id");
            RenameIndex(table: "dbo.OrderNotes", name: "IX_OrderId_Id", newName: "IX_Order_Id");
            RenameIndex(table: "dbo.OrderNotes", name: "IX_WorkerId_Id", newName: "IX_Worker_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_RequestId_Id", newName: "IX_Request_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_StockroomId_Id", newName: "IX_Stockroom_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_SupplierId_Id", newName: "IX_Supplier_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_SupplierPartId_Id", newName: "IX_SupplierPart_Id");
            RenameIndex(table: "dbo.Requests", name: "IX_AssetId_Id", newName: "IX_Asset_Id");
            RenameIndex(table: "dbo.Requests", name: "IX_WorkerId_Id", newName: "IX_Worker_Id");
            RenameIndex(table: "dbo.Requests", name: "IX_WorkOrderId_Id", newName: "IX_WorkOrder_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Requests", name: "IX_WorkOrder_Id", newName: "IX_WorkOrderId_Id");
            RenameIndex(table: "dbo.Requests", name: "IX_Worker_Id", newName: "IX_WorkerId_Id");
            RenameIndex(table: "dbo.Requests", name: "IX_Asset_Id", newName: "IX_AssetId_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_SupplierPart_Id", newName: "IX_SupplierPartId_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_Supplier_Id", newName: "IX_SupplierId_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_Stockroom_Id", newName: "IX_StockroomId_Id");
            RenameIndex(table: "dbo.RequestLines", name: "IX_Request_Id", newName: "IX_RequestId_Id");
            RenameIndex(table: "dbo.OrderNotes", name: "IX_Worker_Id", newName: "IX_WorkerId_Id");
            RenameIndex(table: "dbo.OrderNotes", name: "IX_Order_Id", newName: "IX_OrderId_Id");
            RenameIndex(table: "dbo.SupplierPartIndexes", name: "IX_Supplier_Id", newName: "IX_SupplierId_Id");
            RenameIndex(table: "dbo.SupplierPartIndexes", name: "IX_StockRoom_Id", newName: "IX_StockRoomId_Id");
            RenameColumn(table: "dbo.RequestLines", name: "SupplierPart_Id", newName: "SupplierPartId_Id");
            RenameColumn(table: "dbo.RequestLines", name: "Supplier_Id", newName: "SupplierId_Id");
            RenameColumn(table: "dbo.RequestLines", name: "Stockroom_Id", newName: "StockroomId_Id");
            RenameColumn(table: "dbo.RequestLines", name: "Request_Id", newName: "RequestId_Id");
            RenameColumn(table: "dbo.Requests", name: "WorkOrder_Id", newName: "WorkOrderId_Id");
            RenameColumn(table: "dbo.Requests", name: "Worker_Id", newName: "WorkerId_Id");
            RenameColumn(table: "dbo.Requests", name: "Asset_Id", newName: "AssetId_Id");
            RenameColumn(table: "dbo.OrderNotes", name: "Worker_Id", newName: "WorkerId_Id");
            RenameColumn(table: "dbo.OrderNotes", name: "Order_Id", newName: "OrderId_Id");
            RenameColumn(table: "dbo.SupplierPartIndexes", name: "Supplier_Id", newName: "SupplierId_Id");
            RenameColumn(table: "dbo.SupplierPartIndexes", name: "StockRoom_Id", newName: "StockRoomId_Id");
        }
    }
}
