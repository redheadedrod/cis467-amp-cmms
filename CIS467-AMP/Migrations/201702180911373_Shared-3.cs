namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shared3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetName = c.String(),
                        PartNumber = c.String(),
                        ManId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManId_Id)
                .Index(t => t.ManId_Id);
            
            CreateTable(
                "dbo.PartsListIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartId_Id = c.Int(),
                        VariantId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parts", t => t.PartId_Id)
                .ForeignKey("dbo.Variants", t => t.VariantId_Id)
                .Index(t => t.PartId_Id)
                .Index(t => t.VariantId_Id);
            
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VariantType = c.String(),
                        VariantDescription = c.String(),
                        AssetTypeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetTypeId_Id)
                .Index(t => t.AssetTypeId_Id);
            
            CreateTable(
                "dbo.WorkGroupSupervisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId_Id = c.Int(),
                        WorkGroupId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId_Id)
                .ForeignKey("dbo.WorkGroups", t => t.WorkGroupId_Id)
                .Index(t => t.WorkerId_Id)
                .Index(t => t.WorkGroupId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkGroupSupervisors", "WorkGroupId_Id", "dbo.WorkGroups");
            DropForeignKey("dbo.WorkGroupSupervisors", "WorkerId_Id", "dbo.Workers");
            DropForeignKey("dbo.PartsListIndexes", "VariantId_Id", "dbo.Variants");
            DropForeignKey("dbo.Variants", "AssetTypeId_Id", "dbo.AssetTypes");
            DropForeignKey("dbo.PartsListIndexes", "PartId_Id", "dbo.Parts");
            DropForeignKey("dbo.AssetTypes", "ManId_Id", "dbo.Manufacturers");
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkGroupId_Id" });
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkerId_Id" });
            DropIndex("dbo.Variants", new[] { "AssetTypeId_Id" });
            DropIndex("dbo.PartsListIndexes", new[] { "VariantId_Id" });
            DropIndex("dbo.PartsListIndexes", new[] { "PartId_Id" });
            DropIndex("dbo.AssetTypes", new[] { "ManId_Id" });
            DropTable("dbo.WorkGroupSupervisors");
            DropTable("dbo.Variants");
            DropTable("dbo.PartsListIndexes");
            DropTable("dbo.AssetTypes");
        }
    }
}
