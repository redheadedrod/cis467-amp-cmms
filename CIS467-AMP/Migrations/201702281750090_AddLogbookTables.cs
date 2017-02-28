namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogbookTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogbookGenerals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetInventory_Id = c.Int(),
                        LogbookGeneralStatus_Id = c.Int(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventory_Id)
                .ForeignKey("dbo.LogbookGeneralStatus", t => t.LogbookGeneralStatus_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .Index(t => t.AssetInventory_Id)
                .Index(t => t.LogbookGeneralStatus_Id)
                .Index(t => t.Worker_Id);
            
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
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetInventory_Id = c.Int(),
                        Order_Id = c.Int(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventory_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .Index(t => t.AssetInventory_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.LogbookStockroomRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetInventory_Id = c.Int(),
                        Request_Id = c.Int(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventory_Id)
                .ForeignKey("dbo.Requests", t => t.Request_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .Index(t => t.AssetInventory_Id)
                .Index(t => t.Request_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.LogbookWorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetInventory_Id = c.Int(),
                        Worker_Id = c.Int(),
                        WorkOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventory_Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrder_Id)
                .Index(t => t.AssetInventory_Id)
                .Index(t => t.Worker_Id)
                .Index(t => t.WorkOrder_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogbookWorkOrders", "WorkOrder_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.LogbookWorkOrders", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.LogbookWorkOrders", "AssetInventory_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookStockroomRequests", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.LogbookStockroomRequests", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.LogbookStockroomRequests", "AssetInventory_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookStockroomOrders", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.LogbookStockroomOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.LogbookStockroomOrders", "AssetInventory_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookGenerals", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.LogbookGenerals", "LogbookGeneralStatus_Id", "dbo.LogbookGeneralStatus");
            DropForeignKey("dbo.LogbookGenerals", "AssetInventory_Id", "dbo.AssetInventories");
            DropIndex("dbo.LogbookWorkOrders", new[] { "WorkOrder_Id" });
            DropIndex("dbo.LogbookWorkOrders", new[] { "Worker_Id" });
            DropIndex("dbo.LogbookWorkOrders", new[] { "AssetInventory_Id" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "Worker_Id" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "Request_Id" });
            DropIndex("dbo.LogbookStockroomRequests", new[] { "AssetInventory_Id" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "Worker_Id" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "Order_Id" });
            DropIndex("dbo.LogbookStockroomOrders", new[] { "AssetInventory_Id" });
            DropIndex("dbo.LogbookGenerals", new[] { "Worker_Id" });
            DropIndex("dbo.LogbookGenerals", new[] { "LogbookGeneralStatus_Id" });
            DropIndex("dbo.LogbookGenerals", new[] { "AssetInventory_Id" });
            DropTable("dbo.LogbookWorkOrders");
            DropTable("dbo.LogbookStockroomRequests");
            DropTable("dbo.LogbookStockroomOrders");
            DropTable("dbo.LogbookGeneralStatus");
            DropTable("dbo.LogbookGenerals");
        }
    }
}
