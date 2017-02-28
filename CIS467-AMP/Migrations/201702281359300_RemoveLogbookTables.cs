namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLogbookTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LogbookRecords", "AssetInventory_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.LogbookStatus", "LogbookType_Id", "dbo.LogbookTypes");
            DropForeignKey("dbo.LogbookRecords", "LogbookStatus_Id", "dbo.LogbookStatus");
            DropForeignKey("dbo.LogbookRecords", "LogbookType_Id", "dbo.LogbookTypes");
            DropForeignKey("dbo.LogbookRecords", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.LogbookRecords", new[] { "AssetInventory_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "LogbookStatus_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "LogbookType_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "Worker_Id" });
            DropIndex("dbo.LogbookStatus", new[] { "LogbookType_Id" });
            DropTable("dbo.LogbookRecords");
            DropTable("dbo.LogbookStatus");
            DropTable("dbo.LogbookTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LogbookTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogbookStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LogbookType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogbookRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetInventory_Id = c.Int(),
                        LogbookStatus_Id = c.Int(),
                        LogbookType_Id = c.Int(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.LogbookStatus", "LogbookType_Id");
            CreateIndex("dbo.LogbookRecords", "Worker_Id");
            CreateIndex("dbo.LogbookRecords", "LogbookType_Id");
            CreateIndex("dbo.LogbookRecords", "LogbookStatus_Id");
            CreateIndex("dbo.LogbookRecords", "AssetInventory_Id");
            AddForeignKey("dbo.LogbookRecords", "Worker_Id", "dbo.Workers", "Id");
            AddForeignKey("dbo.LogbookRecords", "LogbookType_Id", "dbo.LogbookTypes", "Id");
            AddForeignKey("dbo.LogbookRecords", "LogbookStatus_Id", "dbo.LogbookStatus", "Id");
            AddForeignKey("dbo.LogbookStatus", "LogbookType_Id", "dbo.LogbookTypes", "Id");
            AddForeignKey("dbo.LogbookRecords", "AssetInventory_Id", "dbo.AssetInventories", "Id");
        }
    }
}
