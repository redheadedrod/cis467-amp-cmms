namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockRoom5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockRoomOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        StockRoomSupplierId = c.Int(nullable: false),
                        MaintenanceWorkOrderId = c.Int(),
                        StockRoomSupplierContactId = c.Int(nullable: false),
                        OrderPlaced = c.DateTime(nullable: false),
                        OrderExpected = c.DateTime(nullable: false),
                        StatusLastUpDate = c.DateTime(nullable: false),
                        StockRoomOrderStatusId = c.Int(nullable: false),
                        OrderApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaintenanceWorkOrders", t => t.MaintenanceWorkOrderId)
                .ForeignKey("dbo.StockRoomOrderStatus", t => t.StockRoomOrderStatusId, cascadeDelete: true)
                .ForeignKey("dbo.StockRoomSuppliers", t => t.StockRoomSupplierId, cascadeDelete: true)
                .ForeignKey("dbo.StockRoomSupplierContacts", t => t.StockRoomSupplierContactId, cascadeDelete: false)
                .Index(t => t.StockRoomSupplierId)
                .Index(t => t.MaintenanceWorkOrderId)
                .Index(t => t.StockRoomSupplierContactId)
                .Index(t => t.StockRoomOrderStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomOrders", "StockRoomSupplierContactId", "dbo.StockRoomSupplierContacts");
            DropForeignKey("dbo.StockRoomOrders", "StockRoomSupplierId", "dbo.StockRoomSuppliers");
            DropForeignKey("dbo.StockRoomOrders", "StockRoomOrderStatusId", "dbo.StockRoomOrderStatus");
            DropForeignKey("dbo.StockRoomOrders", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropIndex("dbo.StockRoomOrders", new[] { "StockRoomOrderStatusId" });
            DropIndex("dbo.StockRoomOrders", new[] { "StockRoomSupplierContactId" });
            DropIndex("dbo.StockRoomOrders", new[] { "MaintenanceWorkOrderId" });
            DropIndex("dbo.StockRoomOrders", new[] { "StockRoomSupplierId" });
            DropTable("dbo.StockRoomOrders");
        }
    }
}
