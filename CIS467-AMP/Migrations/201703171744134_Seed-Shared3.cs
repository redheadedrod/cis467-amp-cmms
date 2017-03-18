namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared3 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AssetTypes ON");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (0, 'Pump', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (1, 'Valve', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (2, 'Piping', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (3, 'Pump', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (4, 'Valve', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (5, 'Piping', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, ManufacturerId) VALUES (6, 'Motor', 1)");
            Sql("SET IDENTITY_INSERT AssetTypes OFF");
            Sql("SET IDENTITY_INSERT ManufacturerParts ON");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (0, 'GR-0104' ,'4 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (1, 'GR-0204' ,'4 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (2, 'GR-0304' ,'4 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (3, 'GR-0108' ,'8 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (4, 'GR-0208' ,'8 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (5, 'GR-0308' ,'8 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (6, 'GR-0112' ,'12 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (7, 'GR-0212' ,'12 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (8, 'GR-0312' ,'12 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (9, 'M-0104' ,'4 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (10, 'M-0204' ,'4 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (11, 'M-0304' ,'4 inch Shaft' , 1, 2 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (12, 'M-0108' ,'8 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (13, 'M-0208' ,'8 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (14, 'M-0308' ,'8 inch Shaft' , 1, 2 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (15, 'M-0112' ,'12 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (16, 'M-0212' ,'12 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO ManufacturerParts (Id, Number, Name, ManufacturerId, ManufacturerPartTypeId ) VALUES (17, 'M-0312' ,'12 inch Shaft' , 1, 2 )");
            Sql("SET IDENTITY_INSERT ManufacturerParts OFF");
            Sql("SET IDENTITY_INSERT Workers ON");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (0, 4,  'Moe', 'Howard', 'Howard, Moe', 'H1234', '555-555-1234', 'MoeH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (1, 0,  'Curly', 'Howard', 'Howard, Curly', 'H2345', '555-555-2345', 'CurlyH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (2, 1,  'Shemp', 'Howard', 'Howard, Shemp', 'H3456', '555-555-3456', 'ShempH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (3, 1,  'Larry', 'Fine', 'Fine, Larry', 'F4567', '555-555-4567', 'LarryH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (4, 2,  'Joe', 'DeRita', 'DeRita, Joe', 'D5678', '555-555-5678', 'JoeD@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroupId, FirstName, LastName, Name, EmployeeId, PhoneNumber, EmailAddress ) VALUES (5, 3,  'Joe', 'Besser', 'Besser, Joe', 'B6789', '555-555-6789', 'JoeBMoe@3stooges.com' )");
            Sql("SET IDENTITY_INSERT Workers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
