namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogbook : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.LogbookGenerals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetInventoryId = c.Int(nullable: false),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        Entry = c.String(),
                        LogbookGeneralStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.LogbookGeneralStatus", t => t.LogbookGeneralStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.WorkerId)
                .Index(t => t.LogbookGeneralStatusId);
            
            CreateTable(
                "dbo.LogbookGeneralStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogbookGenerals", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.LogbookGenerals", "LogbookGeneralStatusId", "dbo.LogbookGeneralStatus");
            DropForeignKey("dbo.LogbookGenerals", "AssetInventoryId", "dbo.AssetInventories");
            DropIndex("dbo.LogbookGenerals", new[] { "LogbookGeneralStatusId" });
            DropIndex("dbo.LogbookGenerals", new[] { "WorkerId" });
            DropIndex("dbo.LogbookGenerals", new[] { "AssetInventoryId" });
            DropTable("dbo.LogbookGeneralStatus");
            DropTable("dbo.LogbookGenerals");
        }
    }
}
