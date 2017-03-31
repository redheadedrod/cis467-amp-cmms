namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationStockroom : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockRoomOrderNotes", "Note", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockRoomOrderNotes", "Note", c => c.String());
        }
    }
}
