namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockRoom3 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockRoomSupplierPartIndexes ON");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (0, 6, 0, 23.5, 03-03-2016, 03-03-2018, 'G-0104' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (1, 7, 0, 24.5, 03-03-2016, 03-03-2018, 'G-0204' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (2, 8, 0, 25.5,  03-03-2016, 03-03-2018, 'G-0304' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (3, 9, 1, 26.5,  03-03-2016, 03-03-2018, 'M-0404' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (4, 10, 1, 27.5,  03-03-2016, 03-03-2018, 'M-0504' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (5, 11, 1, 28.5,  03-03-2016, 03-03-2018, 'M-0604' )");

            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (6, 12, 0, 23.5,  03-03-2016, 03-03-2018, 'G-0108' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (7, 13, 0, 24.5,  03-03-2016, 03-03-2018, 'G-0208' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (8, 14, 0, 25.5,  03-03-2016, 03-03-2018, 'G-0308' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (9, 15, 1, 26.5,  03-03-2016, 03-03-2018, 'M-0408' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (10, 16, 1, 27.5, 03-03-2016, 03-03-2018, 'M-0508' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (11, 17, 1, 28.5,  03-03-2016, 03-03-2018, 'M-0608' )");

            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (12, 18, 0, 29.5, 03-03-2016, 03-03-2018, 'G-0112' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (13, 19, 0, 30.0,  03-03-2016, 03-03-2018, 'G-0212' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (14, 20, 0, 31.2,  03-03-2016, 03-03-2018, 'G-0312' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (15, 21, 1, 32.50,  03-03-2016, 03-03-2018, 'M-0412' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (16, 22, 1, 33.25,  03-03-2016, 03-03-2018, 'M-0512' )");
            Sql("INSERT INTO StockRoomSupplierPartIndexes (Id, ManufacturerPartId, StockRoomSupplierId, Price, DateTimeOfLastPrice, DateTimePriceGoodUntil,  PartNumber) " +
                "VALUES (17, 23, 1, 500.69,  03-03-2016, 03-03-2018, 'M-0612' )");
            Sql("SET IDENTITY_INSERT StockRoomSupplierPartIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
