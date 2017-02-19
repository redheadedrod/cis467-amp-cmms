namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shared2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManufacturerContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                        ManufacturerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId_Id)
                .Index(t => t.ManufacturerId_Id);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartType = c.Int(nullable: false),
                        Number = c.String(),
                        Name = c.String(),
                        ManId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManId_Id)
                .Index(t => t.ManId_Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EmployeeId = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                        WorkGroupId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkGroups", t => t.WorkGroupId_Id)
                .Index(t => t.WorkGroupId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "WorkGroupId_Id", "dbo.WorkGroups");
            DropForeignKey("dbo.Parts", "ManId_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.ManufacturerContacts", "ManufacturerId_Id", "dbo.Manufacturers");
            DropIndex("dbo.Workers", new[] { "WorkGroupId_Id" });
            DropIndex("dbo.Parts", new[] { "ManId_Id" });
            DropIndex("dbo.ManufacturerContacts", new[] { "ManufacturerId_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.Parts");
            DropTable("dbo.ManufacturerContacts");
        }
    }
}
