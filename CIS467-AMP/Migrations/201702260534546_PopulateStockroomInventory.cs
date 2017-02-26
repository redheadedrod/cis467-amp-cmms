namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStockroomInventory : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StockroomInventories ON");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (0, 'SR-0104', 0, 0, 5, 3, 1, 'A:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (1, 'SR-0204', 0, 1, 5, 3, 1, 'A:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (2, 'SR-0304', 0, 2, 5, 3, 1, 'A:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (3, 'SR-0404', 3, 9, 5, 3, 1, 'B:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (4, 'SR-0504', 3, 10, 5, 3, 1, 'B:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (5, 'SR-0604', 3, 11, 5, 3, 3, 'B:3')");

            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (6, 'SR-0108', 1, 3, 5, 3, 1, 'C:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (7, 'SR-0208', 1, 4, 5, 3, 1, 'C:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (8, 'SR-0308', 1, 5, 5, 3, 1, 'C:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (9, 'SR-0408', 4, 12, 5, 3, 1, 'D:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (10, 'SR-0508', 4, 13, 5, 3, 1, 'D:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (11, 'SR-0608', 4, 14, 5, 3, 3, 'D:3')");

            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (12, 'SR-0112', 2, 6, 5, 3, 1, 'E:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (13, 'SR-0212', 2, 7, 5, 3, 1, 'E:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (14, 'SR-0312', 2, 8, 5, 3, 1, 'E:3')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (15, 'SR-0412', 5, 15, 5, 3, 1, 'F:1')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (16, 'SR-0512', 5, 15, 5, 3, 1, 'F:2')");
            Sql("INSERT INTO StockroomInventories (Id, StockId, Variant_Id, Part_Id, OnHand, MinRequired, Reserved, Location)" +
                " VALUES (17, 'SR-0612', 5, 15, 5, 3, 3, 'F:3')");


            Sql("SET IDENTITY_INSERT StockroomInventories OFF");
        }
        
        public override void Down()
        {
        }
    }
}
