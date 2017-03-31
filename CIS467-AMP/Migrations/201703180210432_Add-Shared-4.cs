namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared4 : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.ManufacturerPartParentIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerPartId = c.Int(nullable: false),
                        ManufacturerPartParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartParentId, cascadeDelete: false)
                .Index(t => t.ManufacturerPartId)
                .Index(t => t.ManufacturerPartParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManufacturerPartParentIndexes", "ManufacturerPartParentId", "dbo.ManufacturerParts");
            DropForeignKey("dbo.ManufacturerPartParentIndexes", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropIndex("dbo.ManufacturerPartParentIndexes", new[] { "ManufacturerPartParentId" });
            DropIndex("dbo.ManufacturerPartParentIndexes", new[] { "ManufacturerPartId" });
            DropTable("dbo.ManufacturerPartParentIndexes");
        }
    }
}
