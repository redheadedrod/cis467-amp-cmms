namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaintenancePopulateClassOfIssue : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ClassOfIssues ON");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (0, 'Pipe')");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (1, 'Pump')");
            Sql("INSERT INTO ClassOfIssues (Id, Name) VALUES (2, 'Generator')");
            Sql("SET IDENTITY_INSERT ClassOfIssues OFF");
        }
        
        public override void Down()
        {
        }
    }
}
