namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shared5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        AssetName_Id = c.Int(),
                        MapId_Id = c.Int(),
                        VariantId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetName_Id)
                .ForeignKey("dbo.Maps", t => t.MapId_Id)
                .ForeignKey("dbo.Variants", t => t.VariantId_Id)
                .Index(t => t.AssetName_Id)
                .Index(t => t.MapId_Id)
                .Index(t => t.VariantId_Id);
            
            CreateTable(
                "dbo.JobPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanName = c.String(),
                        VariantId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Variants", t => t.VariantId_Id)
                .Index(t => t.VariantId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPlans", "VariantId_Id", "dbo.Variants");
            DropForeignKey("dbo.AssetInventories", "VariantId_Id", "dbo.Variants");
            DropForeignKey("dbo.AssetInventories", "MapId_Id", "dbo.Maps");
            DropForeignKey("dbo.AssetInventories", "AssetName_Id", "dbo.AssetTypes");
            DropIndex("dbo.JobPlans", new[] { "VariantId_Id" });
            DropIndex("dbo.AssetInventories", new[] { "VariantId_Id" });
            DropIndex("dbo.AssetInventories", new[] { "MapId_Id" });
            DropIndex("dbo.AssetInventories", new[] { "AssetName_Id" });
            DropTable("dbo.JobPlans");
            DropTable("dbo.AssetInventories");
        }
    }
}
