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
                        ManufacturerVariantId = c.Int(nullable: false),
                        MapId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerVariants", t => t.ManufacturerVariantId, cascadeDelete: true)
                .ForeignKey("dbo.Maps", t => t.MapId, cascadeDelete: true)
                .Index(t => t.ManufacturerVariantId)
                .Index(t => t.MapId);
            
            CreateTable(
                "dbo.JobPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanName = c.String(),
                        ManufacturerVariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerVariants", t => t.ManufacturerVariantId, cascadeDelete: true)
                .Index(t => t.ManufacturerVariantId);
            
            CreateTable(
                "dbo.ManufacturerToVariantPartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerPartId = c.Int(nullable: false),
                        ManufacturerVariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerVariants", t => t.ManufacturerVariantId, cascadeDelete: false)
                .Index(t => t.ManufacturerPartId)
                .Index(t => t.ManufacturerVariantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManufacturerToVariantPartIndexes", "ManufacturerVariantId", "dbo.ManufacturerVariants");
            DropForeignKey("dbo.ManufacturerToVariantPartIndexes", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropForeignKey("dbo.JobPlans", "ManufacturerVariantId", "dbo.ManufacturerVariants");
            DropForeignKey("dbo.AssetInventories", "MapId", "dbo.Maps");
            DropForeignKey("dbo.AssetInventories", "ManufacturerVariantId", "dbo.ManufacturerVariants");
            DropIndex("dbo.ManufacturerToVariantPartIndexes", new[] { "ManufacturerVariantId" });
            DropIndex("dbo.ManufacturerToVariantPartIndexes", new[] { "ManufacturerPartId" });
            DropIndex("dbo.JobPlans", new[] { "ManufacturerVariantId" });
            DropIndex("dbo.AssetInventories", new[] { "MapId" });
            DropIndex("dbo.AssetInventories", new[] { "ManufacturerVariantId" });
            DropTable("dbo.ManufacturerToVariantPartIndexes");
            DropTable("dbo.JobPlans");
            DropTable("dbo.AssetInventories");
        }
    }
}
