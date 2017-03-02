namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMaintenanceType : DbMigration
    {
        public override void Up()
        {
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

