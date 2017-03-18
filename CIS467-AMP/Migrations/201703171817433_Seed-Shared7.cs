namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared7 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT JobPlanParts ON");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (0, 0, 0 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (1, 0, 1 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (2, 1, 6 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (3, 1, 7 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (4, 2, 9 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (5, 2, 10 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (6, 2, 11 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (7, 3, 12 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (8, 3, 13 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (9, 3, 14 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (11, 4, 15 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (12, 4, 16 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlanId, ManufacturerPartId ) VALUES (13, 4, 17 )");
            Sql("SET IDENTITY_INSERT JobPlanParts OFF");
            Sql("SET IDENTITY_INSERT JobPlanDocuments ON");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (0,  0, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (1,  1, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (2,  2, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (3,  3, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlanId, Filename) VALUES (4,  4, 'none' )");

            Sql("SET IDENTITY_INSERT JobPlanDocuments OFF");
        }
        
        public override void Down()
        {
        }
    }
}
