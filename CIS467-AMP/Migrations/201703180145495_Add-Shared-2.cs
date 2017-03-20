namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared2 : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.AssetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ManufacturerContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerId = c.Int(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
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
            DropForeignKey("dbo.ManufacturerContacts", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Workers", new[] { "WorkGroupId" });
            DropIndex("dbo.ManufacturerContacts", new[] { "ManufacturerId" });
            DropTable("dbo.Workers");
            DropTable("dbo.ManufacturerContacts");
            DropTable("dbo.AssetTypes");
        }
    }
}
