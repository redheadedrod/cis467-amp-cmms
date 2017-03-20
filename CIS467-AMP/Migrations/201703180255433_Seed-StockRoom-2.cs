namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockRoom2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockroomInventories ON");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (0, 'SR-0104', 6, 5,  3, 1, 'A:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (1, 'SR-0204', 7, 5, 3, 1, 'A:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (2, 'SR-0304', 8, 5, 3, 1, 'A:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (3, 'SR-0404', 15, 5, 3, 1, 'B:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (4, 'SR-0504', 16, 5, 3, 1, 'B:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (5, 'SR-0604', 17, 5, 3, 3, 'B:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (6, 'SR-0108', 9, 5, 3, 1, 'C:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (7, 'SR-0208', 10, 5, 3, 1, 'C:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (8, 'SR-0308', 11, 5, 3, 1, 'C:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (9, 'SR-0408', 18, 5, 3, 1, 'D:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (10, 'SR-0508', 19, 5, 3, 1, 'D:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (11, 'SR-0608', 20, 5, 3, 3, 'D:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (12, 'SR-0112', 12, 5, 3, 1, 'E:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (13, 'SR-0212', 13, 5, 3, 1, 'E:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (14, 'SR-0312', 14, 5,  3, 1, 'E:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (15, 'SR-0412', 21, 5, 3, 1, 'F:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (16, 'SR-0512', 22, 5, 3, 1, 'F:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, ManufacturerPartId, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (17, 'SR-0612', 23, 5, 3, 3, 'F:3')");
            Sql("SET IDENTITY_INSERT StockroomInventories OFF");
            Sql("SET IDENTITY_INSERT StockRoomRequests ON");
            Sql("INSERT INTO StockRoomRequests (Id, WorkerId, MaintenanceWorkOrderId, AssetInventoryId, Requested, Required, Approval, StockroomRequestStatusId) VALUES (0, 1, 0, 0, 12-12-2017, 12-23-2017, 1, 1)");
            Sql("INSERT INTO StockRoomRequests (Id, WorkerId, MaintenanceWorkOrderId, AssetInventoryId, Requested, Required, Approval, StockroomRequestStatusId) VALUES (1, 2, 1, 2, 12-12-2017, 12-23-2017, 1, 2)");
            Sql("INSERT INTO StockRoomRequests (Id, WorkerId, MaintenanceWorkOrderId, AssetInventoryId, Requested, Required, Approval, StockroomRequestStatusId) VALUES (2, 0, 2, 3, 12-12-2017, 12-23-2017, 0, 3)");

            Sql("SET IDENTITY_INSERT StockRoomRequests OFF");
            Sql("SET IDENTITY_INSERT StockRoomSupplierContacts ON");
            Sql("INSERT INTO StockRoomSupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, StockRoomSupplierId) VALUES (0, 'Sales', '616-123-4567', '616-456-7890', 'sales@grainger.com', 0)");
            Sql("INSERT INTO StockRoomSupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, StockRoomSupplierId) VALUES (1, 'Support', '616-555-4567', '616-555-7890', 'support@grainger.com', 0)");
            Sql("INSERT INTO StockRoomSupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, StockRoomSupplierId) VALUES (2, 'Customer Sales', '555-555-4567', '555-555-7890', 'Customer@meijer.com', 1)");
            Sql("INSERT INTO StockRoomSupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, StockRoomSupplierId) VALUES (3, 'Customer Support', '555-555-1234', '555-111-2222', 'Customer@meijer.com', 1)");
            Sql("INSERT INTO StockRoomSupplierContacts (Id, Name, PhoneNumber, FaxNumber, EmailAddress, StockRoomSupplierId) VALUES (4, 'Security', '555-911-4567', NULL, NULL, 1)");
            Sql("SET IDENTITY_INSERT StockRoomSupplierContacts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
