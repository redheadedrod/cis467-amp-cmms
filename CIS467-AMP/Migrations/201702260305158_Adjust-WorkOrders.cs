namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustWorkOrders : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.WorkOrders", name: "StatusId_Id", newName: "MaintenanceStatus_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_StatusId_Id", newName: "IX_MaintenanceStatus_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.WorkOrders", name: "IX_MaintenanceStatus_Id", newName: "IX_StatusId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "MaintenanceStatus_Id", newName: "StatusId_Id");
        }
    }
}
