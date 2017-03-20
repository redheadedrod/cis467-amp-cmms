namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared5 : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.AssetInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerPartId = c.Int(nullable: false),
                        MapId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .ForeignKey("dbo.Maps", t => t.MapId, cascadeDelete: true)
                .Index(t => t.ManufacturerPartId)
                .Index(t => t.MapId);
            
            CreateTable(
                "dbo.JobPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanName = c.String(),
                        ManufacturerPartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .Index(t => t.ManufacturerPartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPlans", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropForeignKey("dbo.AssetInventories", "MapId", "dbo.Maps");
            DropForeignKey("dbo.AssetInventories", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropIndex("dbo.JobPlans", new[] { "ManufacturerPartId" });
            DropIndex("dbo.AssetInventories", new[] { "MapId" });
            DropIndex("dbo.AssetInventories", new[] { "ManufacturerPartId" });
            DropTable("dbo.JobPlans");
            DropTable("dbo.AssetInventories");
        }
    }
}
