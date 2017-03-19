namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.ManufacturerParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        ManufacturerPartTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerPartTypes", t => t.ManufacturerPartTypeId, cascadeDelete: true)
                .Index(t => t.ManufacturerId)
                .Index(t => t.ManufacturerPartTypeId);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkGroupId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Name = c.String(),
                        EmployeeId = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkGroups", t => t.WorkGroupId, cascadeDelete: true)
                .Index(t => t.WorkGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "WorkGroupId", "dbo.WorkGroups");
            DropForeignKey("dbo.ManufacturerParts", "ManufacturerPartTypeId", "dbo.ManufacturerPartTypes");
            DropForeignKey("dbo.ManufacturerParts", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.AssetTypes", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Workers", new[] { "WorkGroupId" });
            DropIndex("dbo.ManufacturerParts", new[] { "ManufacturerPartTypeId" });
            DropIndex("dbo.ManufacturerParts", new[] { "ManufacturerId" });
            DropIndex("dbo.AssetTypes", new[] { "ManufacturerId" });
            DropTable("dbo.Workers");
            DropTable("dbo.ManufacturerParts");
            DropTable("dbo.AssetTypes");
        }
    }
}
