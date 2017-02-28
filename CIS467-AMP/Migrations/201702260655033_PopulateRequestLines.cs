namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRequestLines : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT RequestLines ON");
            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (0, 0, 0, 1, 1, 0, NULL)");
            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (1, 0, 1, 1, 1, 1, NULL)");

            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (2, 1, 6, 1, 1, 6, NULL)");
            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (3, 1, 7, 1, 1, 7, NULL)");

            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (4, 2, 9, 2, 0, 9, NULL)");
            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (5, 2, 10, 2, 0, 10, NULL)");
            Sql("INSERT INTO RequestLines (Id, Request_Id, Stockroom_Id, Number, Supplier_Id, SupplierPart_Id, Description) " +
                "VALUES (6, 2, 11, 1, 0, 11, NULL)");


            Sql("SET IDENTITY_INSERT RequestLines OFF");
        }
        
        public override void Down()
        {
        }
    }
}
