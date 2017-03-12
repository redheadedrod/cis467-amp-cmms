namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockroom1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT OrderStatus ON");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (0, 'Placed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (1, 'Closed - Completed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (2, 'Closed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (3, 'In Transit')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (4, 'Waiting for approval')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (5, 'Recieved - to be checked in yet')");
            Sql("SET IDENTITY_INSERT OrderStatus OFF");
            Sql("SET IDENTITY_INSERT StockroomRequestStatus ON");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (0, 'Waiting Approval')");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (1, 'Approved')");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (2, 'Waiting for items')");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (3, 'Complete, waiting for pickup')");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (4, 'Order Complete')");
            Sql("INSERT INTO StockroomRequestStatus (Id, Name) VALUES (5, 'Order Cancelled')");
            Sql("SET IDENTITY_INSERT StockroomRequestStatus OFF");
            Sql("SET IDENTITY_INSERT Suppliers ON");
            Sql("INSERT INTO Suppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (0, 'Grainger', '1234 Somewhere', 'Nearby', 'Mi', 'USA', '49494')");
            Sql("INSERT INTO Suppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (1, 'Meijer', '1313 Walker', 'Grand Rapids', 'Mi', 'USA', '49513')");
            Sql("SET IDENTITY_INSERT Suppliers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
