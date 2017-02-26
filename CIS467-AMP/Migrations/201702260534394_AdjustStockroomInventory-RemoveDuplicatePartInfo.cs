namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustStockroomInventoryRemoveDuplicatePartInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StockroomInventories", "Name");
            DropColumn("dbo.StockroomInventories", "ManufacturerPartNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockroomInventories", "ManufacturerPartNumber", c => c.String());
            AddColumn("dbo.StockroomInventories", "Name", c => c.String());
        }
    }
}
