namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockRoom6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockRoomOrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomOrderId = c.Int(),
                        StockRoomSupplierPartIndexId = c.Int(nullable: false),
                        NumberOfItemsOrdered = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockRoomOrders", t => t.StockRoomOrderId)
                .ForeignKey("dbo.StockRoomSupplierPartIndexes", t => t.StockRoomSupplierPartIndexId, cascadeDelete: true)
                .Index(t => t.StockRoomOrderId)
                .Index(t => t.StockRoomSupplierPartIndexId);
            
            CreateTable(
                "dbo.StockRoomOrderNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomOrderId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        WhenEntered = c.DateTime(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockRoomOrders", t => t.StockRoomOrderId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.StockRoomOrderId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.StockRoomSpecialOrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomOrderId = c.Int(),
                        StockRoomSupplierPartIndexId = c.Int(nullable: false),
                        NumberOfItemsOrdered = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockRoomOrders", t => t.StockRoomOrderId)
                .ForeignKey("dbo.StockRoomSupplierPartIndexes", t => t.StockRoomSupplierPartIndexId, cascadeDelete: true)
                .Index(t => t.StockRoomOrderId)
                .Index(t => t.StockRoomSupplierPartIndexId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomSpecialOrderLines", "StockRoomSupplierPartIndexId", "dbo.StockRoomSupplierPartIndexes");
            DropForeignKey("dbo.StockRoomSpecialOrderLines", "StockRoomOrderId", "dbo.StockRoomOrders");
            DropForeignKey("dbo.StockRoomOrderNotes", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.StockRoomOrderNotes", "StockRoomOrderId", "dbo.StockRoomOrders");
            DropForeignKey("dbo.StockRoomOrderLines", "StockRoomSupplierPartIndexId", "dbo.StockRoomSupplierPartIndexes");
            DropForeignKey("dbo.StockRoomOrderLines", "StockRoomOrderId", "dbo.StockRoomOrders");
            DropIndex("dbo.StockRoomSpecialOrderLines", new[] { "StockRoomSupplierPartIndexId" });
            DropIndex("dbo.StockRoomSpecialOrderLines", new[] { "StockRoomOrderId" });
            DropIndex("dbo.StockRoomOrderNotes", new[] { "WorkerId" });
            DropIndex("dbo.StockRoomOrderNotes", new[] { "StockRoomOrderId" });
            DropIndex("dbo.StockRoomOrderLines", new[] { "StockRoomSupplierPartIndexId" });
            DropIndex("dbo.StockRoomOrderLines", new[] { "StockRoomOrderId" });
            DropTable("dbo.StockRoomSpecialOrderLines");
            DropTable("dbo.StockRoomOrderNotes");
            DropTable("dbo.StockRoomOrderLines");
        }
    }
}
