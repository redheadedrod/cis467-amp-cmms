namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stockroom1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockroomInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockId = c.String(),
                        Name = c.String(),
                        ManufacturerPartNumber = c.String(),
                        OnHand = c.Int(nullable: false),
                        MinRequired = c.Int(nullable: false),
                        Reserved = c.Int(nullable: false),
                        AssetId_Id = c.Int(),
                        PartId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Variants", t => t.AssetId_Id)
                .ForeignKey("dbo.Parts", t => t.PartId_Id)
                .Index(t => t.AssetId_Id)
                .Index(t => t.PartId_Id);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Requested = c.DateTime(nullable: false),
                        Required = c.DateTime(nullable: false),
                        Approval = c.Boolean(nullable: false),
                        AssetId_Id = c.Int(),
                        WorkerId_Id = c.Int(),
                        WorkOrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetId_Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId_Id)
                .Index(t => t.AssetId_Id)
                .Index(t => t.WorkerId_Id)
                .Index(t => t.WorkOrderId_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "WorkOrderId_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.Requests", "WorkerId_Id", "dbo.Workers");
            DropForeignKey("dbo.Requests", "AssetId_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.StockroomInventories", "PartId_Id", "dbo.Parts");
            DropForeignKey("dbo.StockroomInventories", "AssetId_Id", "dbo.Variants");
            DropIndex("dbo.Requests", new[] { "WorkOrderId_Id" });
            DropIndex("dbo.Requests", new[] { "WorkerId_Id" });
            DropIndex("dbo.Requests", new[] { "AssetId_Id" });
            DropIndex("dbo.StockroomInventories", new[] { "PartId_Id" });
            DropIndex("dbo.StockroomInventories", new[] { "AssetId_Id" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Requests");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.StockroomInventories");
        }
    }
}
