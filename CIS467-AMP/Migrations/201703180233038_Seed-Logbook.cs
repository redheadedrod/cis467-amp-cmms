namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedLogbook : DbMigration
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
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventoryId, WorkerId, LogbookGeneralStatusId, Entry) " +
                "VALUES (0, 2-2-2017, 0, 0, 0, 'Test of the logbook entry system')");
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventoryId, WorkerId, LogbookGeneralStatusId, Entry) " +
                "VALUES (1, 2-3-2017, 1, 2, 3, 'Another Test of the logbook entry system')");
            Sql("INSERT INTO LogbookGenerals (Id, EnteredDateTime, AssetInventoryId, WorkerId, LogbookGeneralStatusId, Entry) " +
                "VALUES (2, 3-3-2017, 2, 3, 1, 'Yet Another Test of the logbook entry system')");
            Sql("SET IDENTITY_INSERT LogbookGeneralS OFF");
        }
        
        public override void Down()
        {
        }
    }
}
