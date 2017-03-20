namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared2 : DbMigration
    {
        public override void Up()
        {
          
            Sql("SET IDENTITY_INSERT ManufacturerContacts ON");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, ManufacturerId) VALUES (0, 'Sales', '616-123-4567', '616-456-7890', 'sales@gorman.com', 0)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, ManufacturerId) VALUES (1, 'Support', '616-555-4567', '616-555-7890', 'support@gorman.com', 0)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, ManufacturerId) VALUES (2, 'Moynal Sales', '555-123-4567', '555-456-7890', 'sales@Moynal.com', 1)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, ManufacturerId) VALUES (3, 'Moynal Support', '555-321-4567', '555-654-7890', 'support@Moynal.com', 1)");
            Sql("SET IDENTITY_INSERT ManufacturerContacts OFF");
            Sql("SET IDENTITY_INSERT AssetTypes ON");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (0, 'Pump')");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (1, 'Valve')");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (2, 'Piping')");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (3, 'Inner Seal')");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (4, 'Outer Seal')");
            Sql("INSERT INTO AssetTypes (Id, Name) VALUES (5, 'Shaft')");
            Sql("SET IDENTITY_INSERT AssetTypes OFF");
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
