namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared2 : DbMigration
    {
        public override void Up()
        {
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
                "dbo.PartTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManufacturerContacts", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.ManufacturerContacts", new[] { "ManufacturerId" });
            DropTable("dbo.PartTypes");
            DropTable("dbo.ManufacturerContacts");
        }
    }
}
