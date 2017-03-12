namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetTypeId = c.Int(nullable: false),
                        VariantType = c.String(),
                        VariantDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetTypeId, cascadeDelete: true)
                .Index(t => t.AssetTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Variants", "AssetTypeId", "dbo.AssetTypes");
            DropIndex("dbo.Variants", new[] { "AssetTypeId" });
            DropTable("dbo.Variants");
        }
    }
}
