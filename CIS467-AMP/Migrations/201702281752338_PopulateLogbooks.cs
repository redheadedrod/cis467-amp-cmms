namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLogbooks : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT LogbookGeneralStatus ON");
            Sql("INSERT INTO LogbookGeneralStatus (Id, Name) VALUES (0, 'General')");
            Sql("INSERT INTO LogbookGeneralStatus (Id, Name) VALUES (1, 'Maintenance')");
            Sql("INSERT INTO LogbookGeneralStatus (Id, Name) VALUES (2, 'Stockroom')");
            Sql("INSERT INTO LogbookGeneralStatus (Id, Name) VALUES (3, 'Delivery')");
            Sql("SET IDENTITY_INSERT LogbookGeneralStatus OFF");
            Sql("SET IDENTITY_INSERT LogbookGenerals ON");
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, LogbookGeneralStatus_Id, Entry) "+
                "VALUES (0, 2-2-2017, 0, 0, 0, 'Test of the logbook entry system')");
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, LogbookGeneralStatus_Id, Entry) " +
                "VALUES (1, 2-3-2017, 1, 2, 3, 'Another Test of the logbook entry system')");
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, LogbookGeneralStatus_Id, Entry) " +
                "VALUES (2, 3-3-2017, 2, 3, 1, 'Yet Another Test of the logbook entry system')");
            Sql("SET IDENTITY_INSERT LogbookGeneralS OFF");
            Sql("SET IDENTITY_INSERT LogbookStockroomOrders ON");
            Sql("INSERT INTO LogbookStockroomOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Order_Id, Entry) " +
                "VALUES (0, 4-1-2017, 0, 0, 0, 'Order placed')");
            Sql("INSERT INTO LogbookStockroomOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Order_Id, Entry) " +
                "VALUES (1, 4-1-2017, 1, 2, 1, 'Order Placed')");
            Sql("INSERT INTO LogbookStockroomOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Order_Id, Entry) " +
                "VALUES (2, 5-1-2017, 2, 3, 2, 'Order Placed')");
            Sql("SET IDENTITY_INSERT LogbookStockroomOrders OFF");
            Sql("SET IDENTITY_INSERT LogbookStockroomRequests ON");
            Sql("INSERT INTO LogbookStockroomRequests (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Request_Id, Entry) " +
                "VALUES (0, 2-2-2017, 0, 0, 0, 'Order Request Received')");
            Sql("INSERT INTO LogbookStockroomRequests (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Request_Id, Entry) " +
                "VALUES (1, 2-3-2017, 1, 2, 1, 'Order Request Received')");
            Sql("INSERT INTO LogbookStockroomRequests (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, Request_Id, Entry) " +
                "VALUES (2, 3-3-2017, 2, 3, 2, 'Order Request Received')");
            Sql("SET IDENTITY_INSERT LogbookStockroomRequests OFF");
            Sql("SET IDENTITY_INSERT LogbookWorkOrders ON");
            Sql("INSERT INTO LogbookWorkOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, WorkOrder_Id, Entry) " +
                "VALUES (0, 2-2-2017, 0, 0, 0, 'Work Order Entered')");
            Sql("INSERT INTO LogbookWorkOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, WorkOrder_Id, Entry) " +
                "VALUES (1, 2-3-2017, 1, 2, 1, 'Work Order Entered')");
            Sql("INSERT INTO LogbookWorkOrders (Id, EnteredDateTime, AssetInventory_Id, Worker_Id, WorkOrder_Id, Entry) " +
                "VALUES (2, 3-3-2017, 2, 3, 2, 'Work Order Entered')");
            Sql("SET IDENTITY_INSERT LogbookWorkOrders OFF");
        }
        
        public override void Down()
        {
        }
    }
}
