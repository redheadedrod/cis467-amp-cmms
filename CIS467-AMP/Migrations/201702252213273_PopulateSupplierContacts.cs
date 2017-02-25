namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSupplierContacts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT SupplierContacts ON");
            Sql("INSERT INTO SupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, SupplierId_Id) VALUES (0, 'Sales', '616-123-4567', '616-456-7890', 'sales@grainger.com', 0)");
            Sql("INSERT INTO SupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, SupplierId_Id) VALUES (1, 'Support', '616-555-4567', '616-555-7890', 'support@grainger.com', 0)");
            Sql("INSERT INTO SupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, SupplierId_Id) VALUES (2, 'Customer Sales', '555-555-4567', '555-555-7890', 'Customer@meijer.com', 1)");
            Sql("INSERT INTO SupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, SupplierId_Id) VALUES (3, 'Customer Support', '555-555-1234', '555-111-2222', 'Customer@meijer.com', 1)");
            Sql("INSERT INTO SupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, SupplierId_Id) VALUES (4, 'Security', '555-911-4567', NULL, NULL, 1)");
            Sql("SET IDENTITY_INSERT SupplierContacts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
