namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logbook1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogbookStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TypeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LogbookTypes", t => t.TypeId_Id)
                .Index(t => t.TypeId_Id);
            
            CreateTable(
                "dbo.LogbookTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogbookStatus", "TypeId_Id", "dbo.LogbookTypes");
            DropIndex("dbo.LogbookStatus", new[] { "TypeId_Id" });
            DropTable("dbo.LogbookTypes");
            DropTable("dbo.LogbookStatus");
        }
    }
}
