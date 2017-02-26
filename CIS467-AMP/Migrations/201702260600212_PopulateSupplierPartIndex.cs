namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSupplierPartIndex : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT SupplierPartIndexes ON");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (0, 0, 0, 23.5, 03-03-2016, 03-03-2018, 'G-0104' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (1, 1, 0, 24.5, 03-03-2016, 03-03-2018, 'G-0204' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (2, 2, 0, 25.5,  03-03-2016, 03-03-2018, 'G-0304' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (3, 3, 1, 26.5,  03-03-2016, 03-03-2018, 'M-0404' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (4, 4, 1, 27.5,  03-03-2016, 03-03-2018, 'M-0504' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (5, 5, 1, 28.5,  03-03-2016, 03-03-2018, 'M-0604' )");

            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (6, 6, 0, 23.5,  03-03-2016, 03-03-2018, 'G-0108' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (7, 7, 0, 24.5,  03-03-2016, 03-03-2018, 'G-0208' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (8, 8, 0, 25.5,  03-03-2016, 03-03-2018, 'G-0308' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (9, 9, 1, 26.5,  03-03-2016, 03-03-2018, 'M-0408' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (10, 10, 1, 27.5, 03-03-2016, 03-03-2018, 'M-0508' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (11, 11, 1, 28.5,  03-03-2016, 03-03-2018, 'M-0608' )");

            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (12, 12, 0, 29.5, 03-03-2016, 03-03-2018, 'G-0112' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (13, 13, 0, 30.0,  03-03-2016, 03-03-2018, 'G-0212' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (14, 14, 0, 31.2,  03-03-2016, 03-03-2018, 'G-0312' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (15, 15, 1, 32.50,  03-03-2016, 03-03-2018, 'M-0412' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (16, 16, 1, 33.25,  03-03-2016, 03-03-2018, 'M-0512' )");
            Sql("INSERT INTO SupplierPartIndexes (Id, Stockroom_Id, Supplier_Id, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (17, 17, 1, 500.69,  03-03-2016, 03-03-2018, 'M-0612' )");


            Sql("SET IDENTITY_INSERT SupplierPartIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
