namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockRoom6 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockRoomOrderLines ON");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (0, 0, 0 , 2, 1)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (1, 0, 1 , 2, 1)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (2, 1, 6 , 1, 0)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (3, 1, 7 , 1, 0)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (4, 2, 9, 3, 1)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (5, 2, 10, 1, 1)");
            Sql("INSERT INTO StockRoomOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (6, 2, 11, 2, 0)");
            Sql("SET IDENTITY_INSERT StockRoomOrderLines OFF");

            Sql("SET IDENTITY_INSERT StockRoomSpecialOrderLines ON");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (0, 0, 3 , 4, 1)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (1, 0, 2 , 5, 1)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (2, 1, 8 , 3, 0)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (3, 1, 5 , 2, 0)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (4, 2, 16, 5, 1)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (5, 2, 17, 3, 1)");
            Sql("INSERT INTO StockRoomSpecialOrderLines (Id, StockRoomOrderId, StockRoomSupplierPartIndexId, NumberOfItemsOrdered, Approved) VALUES (6, 2, 13, 2, 0)");
            Sql("SET IDENTITY_INSERT StockRoomSpecialOrderLines OFF");

            Sql("SET IDENTITY_INSERT StockRoomOrderNotes ON");
            Sql("INSERT INTO StockRoomOrderNotes (Id, WhenEntered, Note, StockRoomOrderId, WorkerId) VALUES (0, 2017-12-12, 'Placed order on 2/23/2017', 0, 0)");
            Sql("INSERT INTO StockRoomOrderNotes (Id, WhenEntered, Note, StockRoomOrderId, WorkerId) VALUES (1, 2017-12-13, 'Order Checked in on 2/23/2017', 2, 3)");
            Sql("INSERT INTO StockRoomOrderNotes (Id, WhenEntered, Note, StockRoomOrderId, WorkerId) VALUES (2, 2017-1-1, 'Placed order on 1/1/2017', 1, 2)");
            Sql("SET IDENTITY_INSERT StockRoomOrderNotes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
