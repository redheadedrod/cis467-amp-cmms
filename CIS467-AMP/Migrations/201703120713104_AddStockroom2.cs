namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockroom2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockroomInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockId = c.String(),
                        VariantId = c.Int(nullable: false),
                        PartId = c.Int(nullable: false),
                        OnHand = c.Int(nullable: false),
                        MinRequired = c.Int(nullable: false),
                        Reserved = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parts", t => t.PartId, cascadeDelete: true)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: false)
                .Index(t => t.VariantId)
                .Index(t => t.PartId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        WorkOrderId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        Requested = c.DateTime(nullable: false),
                        Required = c.DateTime(nullable: false),
                        Approval = c.Boolean(nullable: false),
                        StockroomRequestStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.StockroomRequestStatus", t => t.StockroomRequestStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: false)
                .Index(t => t.WorkerId)
                .Index(t => t.WorkOrderId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.StockroomRequestStatusId);
            
            CreateTable(
                "dbo.SupplierContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierContacts", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Requests", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.Requests", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.Requests", "StockroomRequestStatusId", "dbo.StockroomRequestStatus");
            DropForeignKey("dbo.Requests", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.StockroomInventories", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.StockroomInventories", "PartId", "dbo.Parts");
            DropIndex("dbo.SupplierContacts", new[] { "SupplierId" });
            DropIndex("dbo.Requests", new[] { "StockroomRequestStatusId" });
            DropIndex("dbo.Requests", new[] { "AssetInventoryId" });
            DropIndex("dbo.Requests", new[] { "WorkOrderId" });
            DropIndex("dbo.Requests", new[] { "WorkerId" });
            DropIndex("dbo.StockroomInventories", new[] { "PartId" });
            DropIndex("dbo.StockroomInventories", new[] { "VariantId" });
            DropTable("dbo.SupplierContacts");
            DropTable("dbo.Requests");
            DropTable("dbo.StockroomInventories");
        }
    }
}
