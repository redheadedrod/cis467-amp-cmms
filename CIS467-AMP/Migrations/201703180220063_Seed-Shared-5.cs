namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared5 : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT AssetInventories ON");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, ManufacturerPartId, Name ) VALUES (0,  1, 4, 0, 'Pump #1' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, ManufacturerPartId, Name ) VALUES (1,  1, 4, 1, 'Pump #2' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, ManufacturerPartId, Name ) VALUES (2,  1, 5, 2, 'Pump #3' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, ManufacturerPartId, Name ) VALUES (3,  1, 5, 3, 'Pump #4' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, ManufacturerPartId, Name ) VALUES (4,  0, 5, 4, 'Old Pump #1' )");
            Sql("SET IDENTITY_INSERT AssetInventories OFF");
            Sql("SET IDENTITY_INSERT JobPlans ON");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, ManufacturerPartId) VALUES (0,  'Seal replacement #1', 0 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, ManufacturerPartId) VALUES (1,  'Seal replacement #2', 2 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, ManufacturerPartId) VALUES (2,  'Seal replacement #3', 3 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, ManufacturerPartId) VALUES (3,  'Seal replacement #4', 4 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, ManufacturerPartId) VALUES (4,  'Seal replacement #5', 5 )");
            Sql("SET IDENTITY_INSERT JobPlans OFF");
        }
        
        public override void Down()
        {
        }
    }
}
