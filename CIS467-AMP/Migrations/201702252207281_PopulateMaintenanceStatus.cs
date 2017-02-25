namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMaintenanceStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceStatus ON");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (0, 'Waiting For Approval')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (1, 'In progress')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (2, 'Done')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (3, 'Closed')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (4, 'Waiting For Conditions')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (5, 'Waiting For Scheduling')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (6, 'Waiting For Materials')");
            Sql("INSERT INTO MaintenanceStatus (Id, Name) VALUES (7, 'Waiting For Approval')");
            Sql("SET IDENTITY_INSERT MaintenanceStatus OFF");
        }
        
        public override void Down()
        {
        }
    }
}
