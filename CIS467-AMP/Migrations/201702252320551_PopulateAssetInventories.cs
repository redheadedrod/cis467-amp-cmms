namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAssetInventories : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AssetInventories ON");
            Sql("INSERT INTO AssetInventories (Id, Active, Map_Id, Variant_Id, Name ) VALUES (0,  1, 4, 0, 'Pump #1' )");
            Sql("INSERT INTO AssetInventories (Id, Active, Map_Id, Variant_Id, Name ) VALUES (1,  1, 4, 1, 'Pump #2' )");
            Sql("INSERT INTO AssetInventories (Id, Active, Map_Id, Variant_Id, Name ) VALUES (2,  1, 5, 2, 'Pump #1' )");
            Sql("INSERT INTO AssetInventories (Id, Active, Map_Id, Variant_Id, Name ) VALUES (3,  1, 5, 3, 'Pump #2' )");
            Sql("INSERT INTO AssetInventories (Id, Active, Map_Id, Variant_Id, Name ) VALUES (4,  0, 5, 4, 'Old Pump #1' )");

            Sql("SET IDENTITY_INSERT AssetInventories OFF");
        }
        
        public override void Down()
        {
        }
    }
}
