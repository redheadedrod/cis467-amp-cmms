namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared5 : DbMigration
    {
        public override void Up()
        {
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
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkGroupId" });
            DropIndex("dbo.WorkGroupSupervisors", new[] { "WorkerId" });
            DropTable("dbo.WorkGroupSupervisors");
        }
    }
}
