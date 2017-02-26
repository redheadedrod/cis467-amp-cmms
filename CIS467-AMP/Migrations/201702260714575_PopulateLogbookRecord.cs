namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLogbookRecord : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT LogbookRecords ON");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (0, NULL, 12-12-2017, 0, 2, 'Order M-1001 was placed on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (1, 0, 12-12-2017, 1, 1, 'Work Order 0 was Created on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (2, 1, 12-12-2017, 1, 0, 'I was smacked on the head by pump #1. Nuk Nuk Nuk')");

            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (3, NULL, 12-12-2017, 2, 2, 'Order M-1002 was placed on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (4, 2, 12-12-2017, 4, 1, 'Work Order 1 was Created on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (5, 3, 12-12-2017, 2, 0, 'He was a Wise guy by pump #2.')");

            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (6, NULL, 12-12-2017, 3, 2, 'Order GR-1001 was placed on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (7, 3, 12-12-2017, 2, 1, 'Work Order 2 was Created on 2-28-2017')");
            Sql("INSERT INTO LogbookRecords (Id, AssetInventory_Id, EnteredDateTime, Worker_Id, LogbookType_Id, Entry) " +
                "VALUES (8, 3, 12-12-2017, 3, 0, 'I got poked in the eye by pump #2. Wise Guy!!!')");

            Sql("SET IDENTITY_INSERT LogbookRecords OFF");
        }
        
        public override void Down()
        {
        }
    }
}
