namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceIssueIndexes ON");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (0, 0, 0)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (1, 0, 1)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (2, 0, 2)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (3, 1, 0)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (4, 1, 1)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (5, 1, 2)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (6, 2, 2)");
            Sql("SET IDENTITY_INSERT MaintenanceIssueIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
