namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockRoom4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockRoomRequestLines ON");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (0, 0, 6, 1, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (1, 0, 7, 1, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (2, 1, 12, 1, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (3, 1, 13, 1, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (4, 2, 15, 2, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (5, 2, 16, 2, NULL)");
            Sql("INSERT INTO StockRoomRequestLines (Id, StockRoomRequestId, ManufacturerPartId, Number, Description) " +
                "VALUES (6, 2, 17, 1, NULL)");
            Sql("SET IDENTITY_INSERT StockRoomRequestLines OFF");
        }
        
        public override void Down()
        {
        }
    }
}
