namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeHoursWorkedToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaintenanceWorkOrderWorkTimes", "HoursWorked", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaintenanceWorkOrderWorkTimes", "HoursWorked", c => c.Int(nullable: false));
        }
    }
}
