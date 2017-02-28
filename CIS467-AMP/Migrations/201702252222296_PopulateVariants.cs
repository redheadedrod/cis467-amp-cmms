namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVariants : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Variants ON");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (0, 0, 'Base T Pump', '4 Inch' )");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (1, 0, 'Base T Pump', '8 Inch' )");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (2, 0, 'Base T Pump', '12 Inch' )");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (3, 3, 'Base N Pump', '4 Inch' )");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (4, 3, 'Base N Pump', '8 Inch' )");
            Sql("INSERT INTO Variants (Id, AssetType_Id, VariantType, VariantDescription ) VALUES (5, 3, 'Base N Pump', '12 Inch' )");
            Sql("SET IDENTITY_INSERT Variants OFF");
        }
        
        public override void Down()
        {
        }
    }
}
