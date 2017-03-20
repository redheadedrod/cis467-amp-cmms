namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared4 : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT ManufacturerPartParentIndexes ON");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (0,  6, 0)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (1,  7, 0)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (2,  8, 0)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (3,  9, 1)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (4,  10, 1)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (5,  11, 1)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (6,  12, 2)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (7,  13, 2)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (8,  14, 2)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (9,  15, 3)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (10, 16, 3)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (11, 17, 3)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (12, 18, 4)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (13, 19, 4)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (14, 20, 4)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (15, 21, 5)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (16, 22, 5)");
            Sql("INSERT INTO ManufacturerPartParentIndexes (Id, ManufacturerPartId, ManufacturerPartParentId ) VALUES (17, 23, 5)");
            Sql("SET IDENTITY_INSERT ManufacturerPartParentIndexes OFF");
        }
        public override void Down()
        {
        }
    }
}
