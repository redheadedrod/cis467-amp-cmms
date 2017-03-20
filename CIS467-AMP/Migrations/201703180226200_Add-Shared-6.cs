namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShared6 : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.JobPlanDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanId = c.Int(nullable: false),
                        Filename = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId, cascadeDelete: true)
                .Index(t => t.JobPlanId);
            
            CreateTable(
                "dbo.JobPlanParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobPlanId = c.Int(nullable: false),
                        ManufacturerPartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerParts", t => t.ManufacturerPartId, cascadeDelete: false)
                .Index(t => t.JobPlanId)
                .Index(t => t.ManufacturerPartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPlanParts", "ManufacturerPartId", "dbo.ManufacturerParts");
            DropForeignKey("dbo.JobPlanParts", "JobPlanId", "dbo.JobPlans");
            DropForeignKey("dbo.JobPlanDocuments", "JobPlanId", "dbo.JobPlans");
            DropIndex("dbo.JobPlanParts", new[] { "ManufacturerPartId" });
            DropIndex("dbo.JobPlanParts", new[] { "JobPlanId" });
            DropIndex("dbo.JobPlanDocuments", new[] { "JobPlanId" });
            DropTable("dbo.JobPlanParts");
            DropTable("dbo.JobPlanDocuments");
        }
    }
}
