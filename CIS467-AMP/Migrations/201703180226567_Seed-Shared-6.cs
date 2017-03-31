namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared6 : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT JobPlanParts ON");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (0, 0, 6 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (1, 0, 7 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (2, 1, 12 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (3, 1, 13 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (4, 2, 15 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (5, 2, 16 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (6, 2, 17 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (7, 3, 18 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (8, 3, 19 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (9, 3, 20 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (11, 4, 21 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (12, 4, 22 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (13, 4, 23 )");
            Sql("SET IDENTITY_INSERT JobPlanParts OFF");
            Sql("SET IDENTITY_INSERT JobPlanDocuments ON");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (0,  0, 'none #1' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (1,  1, 'none #2' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (2,  2, 'none #3' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (3,  3, 'none #4' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (4,  4, 'none #5' )");
            Sql("SET IDENTITY_INSERT JobPlanDocuments OFF");
        }
        
        public override void Down()
        {
        }
    }
}
