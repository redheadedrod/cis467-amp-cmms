namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufacturerContacts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ManufacturerContacts ON");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, Manufacturer_Id) VALUES (0, 'Sales', '616-123-4567', '616-456-7890', 'sales@gorman.com', 0)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, Manufacturer_Id) VALUES (1, 'Support', '616-555-4567', '616-555-7890', 'support@gorman.com', 0)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, Manufacturer_Id) VALUES (2, 'Moynal Sales', '555-123-4567', '555-456-7890', 'sales@Moynal.com,', 0)");
            Sql("INSERT INTO ManufacturerContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, Manufacturer_Id) VALUES (3, 'Moynal Support', '555-321-4567', '555-654-7890', 'support@Moynal.com,', 0)");
            Sql("SET IDENTITY_INSERT ManufacturerContacts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
