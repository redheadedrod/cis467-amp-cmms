namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared3 : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT WorkGroupSupervisors ON");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (0,  4,  0)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (1,  4,  1)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (2,  4,  2)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (3,  5,  3)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (4,  5,  4)");
            Sql("SET IDENTITY_INSERT WorkGroupSupervisors OFF");
            Sql("SET IDENTITY_INSERT ManufacturerParts ON");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (0, 0, 0, 'Base T Pump', '4 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (1, 0, 0, 'Base T Pump', '8 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (2, 0, 0, 'Base T Pump', '12 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (3, 0, 1, 'Base N Pump', '4 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (4, 0, 1, 'Base N Pump', '8 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (5, 0, 1, 'Base N Pump', '12 Inch' )");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (6, 3, 0, 'GR-0104' ,'4 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (7, 4, 0, 'GR-0204' ,'4 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (8, 5, 0, 'GR-0304' ,'4 inch Shaft')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (9, 3, 0, 'GR-0108' ,'8 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (10, 4, 0, 'GR-0208' ,'8 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (11, 5, 0, 'GR-0308' ,'8 inch Shaft')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (12, 3, 0, 'GR-0112' ,'12 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (13, 4, 0,'GR-0212' ,'12 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (14, 5, 0, 'GR-0312' ,'12 inch Shaft')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (15, 3, 1, 'M-0104' ,'4 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (16, 4, 1, 'M-0204' ,'4 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (17, 5, 1, 'M-0304' ,'4 inch Shaft')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (18, 3, 1, 'M-0108' ,'8 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (19, 4, 1, 'M-0208' ,'8 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (20, 5, 1, 'M-0308' ,'8 inch Shaft')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (21, 3, 1, 'M-0112' ,'12 inch Inner Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (22, 4, 1, 'M-0212' ,'12 inch Outer Seal')");
            Sql("INSERT INTO ManufacturerParts (Id,  AssetTypeId, ManufacturerId, Number, Name) VALUES (23, 5, 1, 'M-0312' ,'12 inch Shaft')");
            Sql("SET IDENTITY_INSERT ManufacturerParts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
