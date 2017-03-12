namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockroom3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        StockroomInventoryId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        SupplierPartId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .ForeignKey("dbo.StockroomInventories", t => t.StockroomInventoryId, cascadeDelete: false)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.SupplierPartIndexes", t => t.SupplierPartId, cascadeDelete: true)
                .Index(t => t.RequestId)
                .Index(t => t.StockroomInventoryId)
                .Index(t => t.SupplierId)
                .Index(t => t.SupplierPartId);
            
            CreateTable(
                "dbo.SupplierPartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomInventoryId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        DateTimeOfLastPrice = c.DateTime(nullable: false),
                        DateTimePriceGoodUntil = c.DateTime(nullable: false),
                        PartNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockroomInventories", t => t.StockRoomInventoryId, cascadeDelete: false)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: false)
                .Index(t => t.StockRoomInventoryId)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestLines", "SupplierPartId", "dbo.SupplierPartIndexes");
            DropForeignKey("dbo.SupplierPartIndexes", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierPartIndexes", "StockRoomInventoryId", "dbo.StockroomInventories");
            DropForeignKey("dbo.RequestLines", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.RequestLines", "StockroomInventoryId", "dbo.StockroomInventories");
            DropForeignKey("dbo.RequestLines", "RequestId", "dbo.Requests");
            DropIndex("dbo.SupplierPartIndexes", new[] { "SupplierId" });
            DropIndex("dbo.SupplierPartIndexes", new[] { "StockRoomInventoryId" });
            DropIndex("dbo.RequestLines", new[] { "SupplierPartId" });
            DropIndex("dbo.RequestLines", new[] { "SupplierId" });
            DropIndex("dbo.RequestLines", new[] { "StockroomInventoryId" });
            DropIndex("dbo.RequestLines", new[] { "RequestId" });
            DropTable("dbo.SupplierPartIndexes");
            DropTable("dbo.RequestLines");
        }
    }
}
