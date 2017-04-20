namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSystemNews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnteredDateTime = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        Entry = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SystemNews", "WorkerId", "dbo.Workers");
            DropIndex("dbo.SystemNews", new[] { "WorkerId" });
            DropTable("dbo.SystemNews");
        }
    }
}
