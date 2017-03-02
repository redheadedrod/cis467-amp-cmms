namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePartsListIndexes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PartsListIndexes ON");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (0, 0, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (1, 1, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (2, 2, 0 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (3, 3, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (4, 4, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (5, 5, 1 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (6, 6, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (7, 7, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (8, 8, 2 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (9, 9, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (10, 10, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (11, 11, 3 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (12, 12, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (13, 13, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (14, 14, 4 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (15, 15, 5 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (16, 16, 5 )");
            Sql("INSERT INTO PartsListIndexes (Id, Part_Id, Variant_Id ) VALUES (17, 17, 5 )");
            Sql("SET IDENTITY_INSERT PartsListIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}

