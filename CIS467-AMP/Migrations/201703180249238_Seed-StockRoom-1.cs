namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockRoom1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockRoomOrderStatus ON");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (0, 'Placed')");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (1, 'Closed - Completed')");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (2, 'Closed')");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (3, 'In Transit')");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (4, 'Waiting for approval')");
            Sql("INSERT INTO StockRoomOrderStatus (Id, Name) VALUES (5, 'Recieved - to be checked in yet')");
            Sql("SET IDENTITY_INSERT StockRoomOrderStatus OFF");
            Sql("SET IDENTITY_INSERT StockRoomRequestStatus ON");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (0, 'Waiting Approval')");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (1, 'Approved')");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (2, 'Waiting for items')");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (3, 'Complete, waiting for pickup')");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (4, 'Order Complete')");
            Sql("INSERT INTO StockRoomRequestStatus (Id, Name) VALUES (5, 'Order Cancelled')");
            Sql("SET IDENTITY_INSERT StockRoomRequestStatus OFF");
            Sql("SET IDENTITY_INSERT StockRoomSuppliers ON");
            Sql("INSERT INTO StockRoomSuppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (0, 'Grainger', '1234 Somewhere', 'Nearby', 'Mi', 'USA', '49494')");
            Sql("INSERT INTO StockRoomSuppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (1, 'Meijer', '1313 Walker', 'Grand Rapids', 'Mi', 'USA', '49513')");
            Sql("SET IDENTITY_INSERT StockRoomSuppliers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
