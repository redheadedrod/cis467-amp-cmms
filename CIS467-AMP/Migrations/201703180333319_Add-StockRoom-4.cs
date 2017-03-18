namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockRoom4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockRoomRequestLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockRoomRequestId = c.Int(nullable: false),
                        ManufacturerPartId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .ForeignKey("dbo.StockRoomRequests", t => t.StockRoomRequestId, cascadeDelete: false)
                .Index(t => t.StockRoomRequestId)
                .Index(t => t.ManufacturerPartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomRequestLines", "StockRoomRequestId", "dbo.StockRoomRequests");
            DropForeignKey("dbo.StockRoomRequestLines", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropIndex("dbo.StockRoomRequestLines", new[] { "ManufacturerPartId" });
            DropIndex("dbo.StockRoomRequestLines", new[] { "StockRoomRequestId" });
            DropTable("dbo.StockRoomRequestLines");
        }
    }
}
