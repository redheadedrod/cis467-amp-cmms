namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderPartIndexes ON");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (0, 0 , 0, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (1, 1 , 0, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (2,  6, 1, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (3,  7, 1, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (4,  9, 2, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (5,  10, 2, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderPartIndexes (Id, ManufacturerToVariantPartIndexId, MaintenanceWorkOrderId , Number ) VALUES (6,  11, 2, 3)");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderPartIndexes OFF");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderWorkTimes ON");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (0, 2017-3-1, 3, 0, 1)");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (1, 2017-3-2, 2, 1, 2)");
            Sql("INSERT INTO MaintenanceWorkOrderWorkTimes (Id, StartTime, HoursWorked, WorkerId, MaintenanceWorkOrderId ) VALUES (2, 2017-3-2, 2, 2, 2)");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrderWorkTimes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
