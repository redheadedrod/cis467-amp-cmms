namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAssetFromPartsRequest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StockRoomRequests", "AssetInventoryId", "dbo.AssetInventories");
            DropIndex("dbo.StockRoomRequests", new[] { "AssetInventoryId" });
            DropColumn("dbo.StockRoomRequests", "AssetInventoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockRoomRequests", "AssetInventoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.StockRoomRequests", "AssetInventoryId");
            AddForeignKey("dbo.StockRoomRequests", "AssetInventoryId", "dbo.AssetInventories", "Id", cascadeDelete: true);
        }
    }
}
