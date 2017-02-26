namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustOrders : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "OrderStatusId_Id", newName: "OrderStatus_Id");
            RenameColumn(table: "dbo.Orders", name: "SupplierContactId_Id", newName: "SupplierContact_Id");
            RenameColumn(table: "dbo.Orders", name: "SupplierId_Id", newName: "Supplier_Id");
            RenameColumn(table: "dbo.Orders", name: "WorkOrderId_Id", newName: "WorkOrder_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_OrderStatusId_Id", newName: "IX_OrderStatus_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_SupplierId_Id", newName: "IX_Supplier_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_SupplierContactId_Id", newName: "IX_SupplierContact_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_WorkOrderId_Id", newName: "IX_WorkOrder_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_WorkOrder_Id", newName: "IX_WorkOrderId_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_SupplierContact_Id", newName: "IX_SupplierContactId_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_Supplier_Id", newName: "IX_SupplierId_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_OrderStatus_Id", newName: "IX_OrderStatusId_Id");
            RenameColumn(table: "dbo.Orders", name: "WorkOrder_Id", newName: "WorkOrderId_Id");
            RenameColumn(table: "dbo.Orders", name: "Supplier_Id", newName: "SupplierId_Id");
            RenameColumn(table: "dbo.Orders", name: "SupplierContact_Id", newName: "SupplierContactId_Id");
            RenameColumn(table: "dbo.Orders", name: "OrderStatus_Id", newName: "OrderStatusId_Id");
        }
    }
}
