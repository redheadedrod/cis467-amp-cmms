namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared6 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AssetInventories ON");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, VariantId, Name ) VALUES (0,  1, 4, 0, 'Pump #1' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, VariantId, Name ) VALUES (1,  1, 4, 1, 'Pump #2' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, VariantId, Name ) VALUES (2,  1, 5, 2, 'Pump #1' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, VariantId, Name ) VALUES (3,  1, 5, 3, 'Pump #2' )");
            Sql("INSERT INTO AssetInventories (Id, Active, MapId, VariantId, Name ) VALUES (4,  0, 5, 4, 'Old Pump #1' )");
            Sql("SET IDENTITY_INSERT AssetInventories OFF");
            Sql("SET IDENTITY_INSERT JobPlans ON");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, VariantId) VALUES (0,  'Seal replacement', 0 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, VariantId) VALUES (1,  'Seal replacement', 2 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, VariantId) VALUES (2,  'Seal replacement', 3 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, VariantId) VALUES (3,  'Seal replacement', 4 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, VariantId) VALUES (4,  'Seal replacement', 5 )");
            Sql("SET IDENTITY_INSERT JobPlans OFF");
            Sql("SET IDENTITY_INSERT PartsListIndexes ON");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (0, 0, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (1, 1, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (2, 2, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (3, 3, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (4, 4, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (5, 5, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (6, 6, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (7, 7, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (8, 8, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (9, 9, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (10, 10, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (11, 11, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (12, 12, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (13, 13, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (14, 14, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (15, 15, 5 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (16, 16, 5 )");
            Sql("INSERT INTO PartsListIndexes (Id, PartId, VariantId ) VALUES (17, 17, 5 )");
            Sql("SET IDENTITY_INSERT PartsListIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
