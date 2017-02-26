namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOrderLines : DbMigration
    {
        public override void Up()
        {

            Sql("SET IDENTITY_INSERT OrderLines ON");
            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (0, 0, 0 , 2)");
            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (1, 0, 1 , 2)");

            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (2, 1, 6 , 1)");
            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (3, 1, 7 , 1)");

            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (4, 2, 9, 3)");
            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (5, 2, 10, 1)");
            Sql("INSERT INTO OrderLines (Id, Order_Id, SupplierPartIndex_Id, NumberOfItemsOrdered) VALUES (6, 2, 11, 2)");

            Sql("SET IDENTITY_INSERT OrderLines OFF");
        }
        
        public override void Down()
        {
        }
    }
}
