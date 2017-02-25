namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIssueIndex : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Issues", "IssueClass_Id", "dbo.ClassOfIssues");
            DropIndex("dbo.Issues", new[] { "IssueClass_Id" });
            CreateTable(
                "dbo.IssueIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId_Id = c.Int(),
                        IssueId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassOfIssues", t => t.ClassId_Id)
                .ForeignKey("dbo.Issues", t => t.IssueId_Id)
                .Index(t => t.ClassId_Id)
                .Index(t => t.IssueId_Id);
            
            DropColumn("dbo.Issues", "IssueClass_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Issues", "IssueClass_Id", c => c.Int());
            DropForeignKey("dbo.IssueIndexes", "IssueId_Id", "dbo.Issues");
            DropForeignKey("dbo.IssueIndexes", "ClassId_Id", "dbo.ClassOfIssues");
            DropIndex("dbo.IssueIndexes", new[] { "IssueId_Id" });
            DropIndex("dbo.IssueIndexes", new[] { "ClassId_Id" });
            DropTable("dbo.IssueIndexes");
            CreateIndex("dbo.Issues", "IssueClass_Id");
            AddForeignKey("dbo.Issues", "IssueClass_Id", "dbo.ClassOfIssues", "Id");
        }
    }
}
