namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderPartIndexes ON");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (0, 6 , 0, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (1, 7 , 0, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (2,  12, 1, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (3,  13, 1, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (4,  15, 2, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (5,  16, 2, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerPartId, MaintenanceWorkOrderId , Number ) VALUES (6,  17, 2, 3)");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderPartIndexes OFF");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderWorkTimes ON");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (0, 3-1-2017, 3, 0, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (1, 3-2-2017, 2, 1, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (2, 3-2-2017, 2, 2, 2)");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderWorkTimes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
