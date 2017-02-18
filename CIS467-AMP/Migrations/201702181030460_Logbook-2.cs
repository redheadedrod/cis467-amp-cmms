namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logbook2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogbookRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        Entry = c.String(),
                        AssetId_Id = c.Int(),
                        StatusId_Id = c.Int(),
                        TypeId_Id = c.Int(),
                        WorkerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetId_Id)
                .ForeignKey("dbo.LogbookStatus", t => t.StatusId_Id)
                .ForeignKey("dbo.LogbookTypes", t => t.TypeId_Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId_Id)
                .Index(t => t.AssetId_Id)
                .Index(t => t.StatusId_Id)
                .Index(t => t.TypeId_Id)
                .Index(t => t.WorkerId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogbookRecords", "WorkerId_Id", "dbo.Workers");
            DropForeignKey("dbo.LogbookRecords", "TypeId_Id", "dbo.LogbookTypes");
            DropForeignKey("dbo.LogbookRecords", "StatusId_Id", "dbo.LogbookStatus");
            DropForeignKey("dbo.LogbookRecords", "AssetId_Id", "dbo.AssetInventories");
            DropIndex("dbo.LogbookRecords", new[] { "WorkerId_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "TypeId_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "StatusId_Id" });
            DropIndex("dbo.LogbookRecords", new[] { "AssetId_Id" });
            DropTable("dbo.LogbookRecords");
        }
    }
}
