namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockRoom2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockRoomInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockId = c.String(),
                        ManufacturerPartId = c.Int(nullable: false),
                        OnHand = c.Int(nullable: false),
                        MinRequired = c.Int(nullable: false),
                        Reserved = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .Index(t => t.ManufacturerPartId);
            
            CreateTable(
                "dbo.StockRoomRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        MaintenanceWorkOrderId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        Requested = c.DateTime(nullable: false),
                        Required = c.DateTime(nullable: false),
                        Approval = c.Boolean(nullable: false),
                        StockRoomRequestStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.MaintenanceWorkOrders", t => t.MaintenanceWorkOrderId, cascadeDelete: false)
                .ForeignKey("dbo.StockRoomRequestStatus", t => t.StockRoomRequestStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.WorkerId)
                .Index(t => t.MaintenanceWorkOrderId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.StockRoomRequestStatusId);
            
            CreateTable(
                "dbo.StockRoomSupplierContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomSupplierId = c.Int(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockRoomSuppliers", t => t.StockRoomSupplierId, cascadeDelete: true)
                .Index(t => t.StockRoomSupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomSupplierContacts", "StockRoomSupplierId", "dbo.StockRoomSuppliers");
            DropForeignKey("dbo.StockRoomRequests", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.StockRoomRequests", "StockRoomRequestStatusId", "dbo.StockRoomRequestStatus");
            DropForeignKey("dbo.StockRoomRequests", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropForeignKey("dbo.StockRoomRequests", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.StockRoomInventories", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropIndex("dbo.StockRoomSupplierContacts", new[] { "StockRoomSupplierId" });
            DropIndex("dbo.StockRoomRequests", new[] { "StockRoomRequestStatusId" });
            DropIndex("dbo.StockRoomRequests", new[] { "AssetInventoryId" });
            DropIndex("dbo.StockRoomRequests", new[] { "MaintenanceWorkOrderId" });
            DropIndex("dbo.StockRoomRequests", new[] { "WorkerId" });
            DropIndex("dbo.StockRoomInventories", new[] { "ManufacturerPartId" });
            DropTable("dbo.StockRoomSupplierContacts");
            DropTable("dbo.StockRoomRequests");
            DropTable("dbo.StockRoomInventories");
        }
    }
}
