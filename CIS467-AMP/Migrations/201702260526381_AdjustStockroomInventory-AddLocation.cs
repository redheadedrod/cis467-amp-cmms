namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustStockroomInventoryAddLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockroomInventories", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockroomInventories", "Location");
        }
    }
}
