namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustStockroomInventory : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.StockroomInventories", name: "AssetId_Id", newName: "Variant_Id");
            RenameColumn(table: "dbo.StockroomInventories", name: "PartId_Id", newName: "Part_Id");
            RenameIndex(table: "dbo.StockroomInventories", name: "IX_PartId_Id", newName: "IX_Part_Id");
            RenameIndex(table: "dbo.StockroomInventories", name: "IX_AssetId_Id", newName: "IX_Variant_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.StockroomInventories", name: "IX_Variant_Id", newName: "IX_AssetId_Id");
            RenameIndex(table: "dbo.StockroomInventories", name: "IX_Part_Id", newName: "IX_PartId_Id");
            RenameColumn(table: "dbo.StockroomInventories", name: "Part_Id", newName: "PartId_Id");
            RenameColumn(table: "dbo.StockroomInventories", name: "Variant_Id", newName: "AssetId_Id");
        }
    }
}
