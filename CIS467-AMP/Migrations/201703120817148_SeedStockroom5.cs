namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockroom5 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT OrderLines ON");
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (0, 0, 0 , 2)");
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (1, 0, 1 , 2)");
            
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (2, 1, 6 , 1)");
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (3, 1, 7 , 1)");

            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (4, 2, 9, 3)");
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (5, 2, 10, 1)");
            Sql("INSERT INTO OrderLines (Id, OrderId, SupplierPartIndexId, NumberOfItemsOrdered) VALUES (6, 2, 11, 2)");

            Sql("SET IDENTITY_INSERT OrderLines OFF");
            Sql("SET IDENTITY_INSERT OrderNotes ON");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, OrderId, WorkerId) VALUES (0, 2017-12-12, 'Placed order on 2/23/2017', 0, 0)");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, OrderId, WorkerId) VALUES (1, 2017-12-13, 'Order Checked in on 2/23/2017', 2, 3)");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, OrderId, WorkerId) VALUES (2, 2017-1-1, 'Placed order on 1/1/2017', 1, 2)");
            Sql("SET IDENTITY_INSERT OrderNotes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
