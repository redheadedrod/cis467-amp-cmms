namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidateWorkOrders : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaintenanceWorkOrders", "ShortDesc", c => c.String(maxLength: 40));
            AlterColumn("dbo.MaintenanceWorkOrders", "LongDesc", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaintenanceWorkOrders", "LongDesc", c => c.String());
            AlterColumn("dbo.MaintenanceWorkOrders", "ShortDesc", c => c.String());
        }
    }
}
