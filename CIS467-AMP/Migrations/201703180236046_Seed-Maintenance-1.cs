namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceClassOfIssues ON");
            Sql("INSERT INTO MaintenanceClassOfIssues (Id, Name) VALUES (0, 'Pipe')");
            Sql("INSERT INTO MaintenanceClassOfIssues (Id, Name) VALUES (1, 'Pump')");
            Sql("INSERT INTO MaintenanceClassOfIssues (Id, Name) VALUES (2, 'Generator')");
            Sql("SET IDENTITY_INSERT MaintenanceClassOfIssues OFF");
        }
        
        public override void Down()
        {
        }
    }
}
