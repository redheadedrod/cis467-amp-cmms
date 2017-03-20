namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared3 : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.ManufacturerParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetTypeId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        Name = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.AssetTypeId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.WorkGroupSupervisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        WorkGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .ForeignKey("dbo.WorkGroups", t => t.WorkGroupId, cascadeDelete: false)
                .Index(t => t.WorkerId)
                .Index(t => t.WorkGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkGroupSupervisors", "WorkGroupId", "dbo.WorkGroups");
            DropForeignKey("dbo.WorkGroupSupervisors", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.ManufacturerParts", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.ManufacturerParts", "AssetTypeId", "dbo.AssetTypes");
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkGroupId" });
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkerId" });
            DropIndex("dbo.ManufacturerParts", new[] { "ManufacturerId" });
            DropIndex("dbo.ManufacturerParts", new[] { "AssetTypeId" });
            DropTable("dbo.WorkGroupSupervisors");
            DropTable("dbo.ManufacturerParts");
        }
    }
}
