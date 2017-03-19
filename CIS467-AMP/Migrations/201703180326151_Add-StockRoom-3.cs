namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockRoom3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockRoomSupplierPartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerPartId = c.Int(nullable: false),
                        StockRoomSupplierId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        DateTimeOfLastPrice = c.DateTime(nullable: false),
                        DateTimePriceGoodUntil = c.DateTime(nullable: false),
                        PartNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .ForeignKey("dbo.StockRoomSuppliers", t => t.StockRoomSupplierId, cascadeDelete: true)
                .Index(t => t.ManufacturerPartId)
                .Index(t => t.StockRoomSupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomSupplierPartIndexes", "StockRoomSupplierId", "dbo.StockRoomSuppliers");
            DropForeignKey("dbo.StockRoomSupplierPartIndexes", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropIndex("dbo.StockRoomSupplierPartIndexes", new[] { "StockRoomSupplierId" });
            DropIndex("dbo.StockRoomSupplierPartIndexes", new[] { "ManufacturerPartId" });
            DropTable("dbo.StockRoomSupplierPartIndexes");
        }
    }
}
