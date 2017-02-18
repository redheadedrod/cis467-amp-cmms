namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shared6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobPlanDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Filename = c.String(),
                        JobPlanId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId_Id)
                .Index(t => t.JobPlanId_Id);
            
            CreateTable(
                "dbo.JobPlanParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanId_Id = c.Int(),
                        PartId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId_Id)
                .ForeignKey("dbo.Parts", t => t.PartId_Id)
                .Index(t => t.JobPlanId_Id)
                .Index(t => t.PartId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPlanParts", "PartId_Id", "dbo.Parts");
            DropForeignKey("dbo.JobPlanParts", "JobPlanId_Id", "dbo.JobPlans");
            DropForeignKey("dbo.JobPlanDocuments", "JobPlanId_Id", "dbo.JobPlans");
            DropIndex("dbo.JobPlanParts", new[] { "PartId_Id" });
            DropIndex("dbo.JobPlanParts", new[] { "JobPlanId_Id" });
            DropIndex("dbo.JobPlanDocuments", new[] { "JobPlanId_Id" });
            DropTable("dbo.JobPlanParts");
            DropTable("dbo.JobPlanDocuments");
        }
    }
}
