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
            Sql("SET IDENTITY_INSERT PartTypes ON");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (0, 'Inner Seal')");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (1, 'Outer Seal')");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (2, 'Shaft')");
            Sql("SET IDENTITY_INSERT PartTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
