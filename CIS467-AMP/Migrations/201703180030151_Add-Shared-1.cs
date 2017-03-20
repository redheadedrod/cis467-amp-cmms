namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared1 : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                        Longitude = c.Single(nullable: false),
                        Latitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkGroups");
            DropTable("dbo.Maps");
            DropTable("dbo.Manufacturers");
        }
    }
}
