namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IssueIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassOfissueId = c.Int(nullable: false),
                        IssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassOfIssues", t => t.ClassOfissueId, cascadeDelete: true)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .Index(t => t.ClassOfissueId)
                .Index(t => t.IssueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IssueIndexes", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.IssueIndexes", "ClassOfissueId", "dbo.ClassOfIssues");
            DropIndex("dbo.IssueIndexes", new[] { "IssueId" });
            DropIndex("dbo.IssueIndexes", new[] { "ClassOfissueId" });
            DropTable("dbo.IssueIndexes");
        }
    }
}
