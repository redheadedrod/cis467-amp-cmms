namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ManufacturerVariants ON");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (0, 0, 'Base T Pump', '4 Inch' )");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (1, 0, 'Base T Pump', '8 Inch' )");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (2, 0, 'Base T Pump', '12 Inch' )");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (3, 3, 'Base N Pump', '4 Inch' )");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (4, 3, 'Base N Pump', '8 Inch' )");
            Sql("INSERT INTO ManufacturerVariants (Id, AssetTypeId, Name, Description ) VALUES (5, 3, 'Base N Pump', '12 Inch' )");
            Sql("SET IDENTITY_INSERT ManufacturerVariants OFF");
        }
        
        public override void Down()
        {
        }
    }
}
