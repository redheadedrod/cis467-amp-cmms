namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManufacturerVariants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetTypeId, cascadeDelete: true)
                .Index(t => t.AssetTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManufacturerVariants", "AssetTypeId", "dbo.AssetTypes");
            DropIndex("dbo.ManufacturerVariants", new[] { "AssetTypeId" });
            DropTable("dbo.ManufacturerVariants");
        }
    }
}
