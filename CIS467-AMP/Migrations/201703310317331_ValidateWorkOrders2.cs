namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidateWorkOrders2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaintenanceWorkOrders", "LeadWorkerId", "dbo.Workers");
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "LeadWorkerId" });
            AlterColumn("dbo.MaintenanceWorkOrders", "LeadWorkerId", c => c.Int());
            CreateIndex("dbo.MaintenanceWorkOrders", "LeadWorkerId");
            AddForeignKey("dbo.MaintenanceWorkOrders", "LeadWorkerId", "dbo.Workers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintenanceWorkOrders", "LeadWorkerId", "dbo.Workers");
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "LeadWorkerId" });
            AlterColumn("dbo.MaintenanceWorkOrders", "LeadWorkerId", c => c.Int(nullable: false));
            CreateIndex("dbo.MaintenanceWorkOrders", "LeadWorkerId");
            AddForeignKey("dbo.MaintenanceWorkOrders", "LeadWorkerId", "dbo.Workers", "Id", cascadeDelete: true);
        }
    }
}
