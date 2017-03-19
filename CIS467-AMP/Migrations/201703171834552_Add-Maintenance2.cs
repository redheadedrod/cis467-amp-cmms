namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaintenanceIssueIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaintenanceClassOfIssueId = c.Int(nullable: false),
                        MaintenanceIssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaintenanceClassOfIssues", t => t.MaintenanceClassOfIssueId, cascadeDelete: true)
                .ForeignKey("dbo.MaintenanceIssues", t => t.MaintenanceIssueId, cascadeDelete: true)
                .Index(t => t.MaintenanceClassOfIssueId)
                .Index(t => t.MaintenanceIssueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintenanceIssueIndexes", "MaintenanceIssueId", "dbo.MaintenanceIssues");
            DropForeignKey("dbo.MaintenanceIssueIndexes", "MaintenanceClassOfIssueId", "dbo.MaintenanceClassOfIssues");
            DropIndex("dbo.MaintenanceIssueIndexes", new[] { "MaintenanceIssueId" });
            DropIndex("dbo.MaintenanceIssueIndexes", new[] { "MaintenanceClassOfIssueId" });
            DropTable("dbo.MaintenanceIssueIndexes");
        }
    }
}
