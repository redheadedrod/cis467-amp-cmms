namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VariantId = c.Int(nullable: false),
                        MapId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Maps", t => t.MapId, cascadeDelete: true)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: true)
                .Index(t => t.VariantId)
                .Index(t => t.MapId);
            
            CreateTable(
                "dbo.JobPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanName = c.String(),
                        VariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: true)
                .Index(t => t.VariantId);
            
            CreateTable(
                "dbo.PartsListIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartId = c.Int(nullable: false),
                        VariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parts", t => t.PartId, cascadeDelete: true)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: false)
                .Index(t => t.PartId)
                .Index(t => t.VariantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PartsListIndexes", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.PartsListIndexes", "PartId", "dbo.Parts");
            DropForeignKey("dbo.JobPlans", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.AssetInventories", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.AssetInventories", "MapId", "dbo.Maps");
            DropIndex("dbo.PartsListIndexes", new[] { "VariantId" });
            DropIndex("dbo.PartsListIndexes", new[] { "PartId" });
            DropIndex("dbo.JobPlans", new[] { "VariantId" });
            DropIndex("dbo.AssetInventories", new[] { "MapId" });
            DropIndex("dbo.AssetInventories", new[] { "VariantId" });
            DropTable("dbo.PartsListIndexes");
            DropTable("dbo.JobPlans");
            DropTable("dbo.AssetInventories");
        }
    }
}
