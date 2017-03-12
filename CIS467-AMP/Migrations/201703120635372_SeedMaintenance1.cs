namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ClassOfIssues ON");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (0, 'Pipe')");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (1, 'Pump')");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (2, 'Generator')");
            Sql("SET IDENTITY_INSERT ClassOfIssues OFF");
            Sql("SET IDENTITY_INSERT Issues ON");
            Sql("INSERT INTO Issues (Id, Name) VALUES (0, 'Leak')");
            Sql("INSERT INTO Issues (Id, Name) VALUES (1, 'Loose')");
            Sql("INSERT INTO Issues (Id, Name) VALUES (2, 'Failed')");
            Sql("SET IDENTITY_INSERT Issues OFF");
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
            Sql("SET IDENTITY_INSERT MaintenanceTypes ON");
            Sql("INSERT INTO MaintenanceTypes (Id, Name) VALUES (0, 'Corrective')");
            Sql("INSERT INTO MaintenanceTypes (Id, Name) VALUES (1, 'Preventative')");
            Sql("INSERT INTO MaintenanceTypes (Id, Name) VALUES (2, 'Safety')");
            Sql("INSERT INTO MaintenanceTypes (Id, Name) VALUES (3, 'New Installation')");
            Sql("SET IDENTITY_INSERT MaintenanceTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
