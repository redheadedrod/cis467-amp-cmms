namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogbook1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogbookGenerals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entry = c.String(),
                        LogbookGeneralStatusId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.LogbookGeneralStatus", t => t.LogbookGeneralStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.LogbookGeneralStatusId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.LogbookGeneralStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogbookStockroomOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: false)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.LogbookStockroomRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: false)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.RequestId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.LogbookWorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkOrderId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: false)
                .Index(t => t.WorkOrderId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogbookWorkOrders", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.LogbookWorkOrders", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.LogbookWorkOrders", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookStockroomRequests", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.LogbookStockroomRequests", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.LogbookStockroomRequests", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookStockroomOrders", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.LogbookStockroomOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.LogbookStockroomOrders", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookGenerals", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.LogbookGenerals", "LogbookGeneralStatusId", "dbo.LogbookGeneralStatus");
            DropForeignKey("dbo.LogbookGenerals", "AssetInventoryId", "dbo.AssetInventories");
            DropIndex("dbo.LogbookWorkOrders", new[] { "WorkerId" });
            DropIndex("dbo.LogbookWorkOrders", new[] { "AssetInventoryId" });
            DropIndex("dbo.LogbookWorkOrders", new[] { "WorkOrderId" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "WorkerId" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "AssetInventoryId" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "RequestId" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "WorkerId" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "AssetInventoryId" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "OrderId" });
            DropIndex("dbo.LogbookGenerals", new[] { "WorkerId" });
            DropIndex("dbo.LogbookGenerals", new[] { "AssetInventoryId" });
            DropIndex("dbo.LogbookGenerals", new[] { "LogbookGeneralStatusId" });
            DropTable("dbo.LogbookWorkOrders");
            DropTable("dbo.LogbookStockroomRequests");
            DropTable("dbo.LogbookStockroomOrders");
            DropTable("dbo.LogbookGeneralStatus");
            DropTable("dbo.LogbookGenerals");
        }
    }
}
