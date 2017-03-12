namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorId = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        MaintenanceStatusId = c.Int(nullable: false),
                        LastStatusDateTime = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        SupervisorId = c.Int(nullable: false),
                        LeadWorkerId = c.Int(nullable: false),
                        AssetInventoryId = c.Int(nullable: false),
                        ShortDesc = c.String(),
                        LongDesc = c.String(),
                        JobPlanId = c.Int(nullable: false),
                        IssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.CreatorId, cascadeDelete: true)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId, cascadeDelete: false)
                .ForeignKey("dbo.Workers", t => t.LeadWorkerId, cascadeDelete: false)
                .ForeignKey("dbo.MaintenanceStatus", t => t.MaintenanceStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.SupervisorId, cascadeDelete: false)
                .Index(t => t.CreatorId)
                .Index(t => t.MaintenanceStatusId)
                .Index(t => t.SupervisorId)
                .Index(t => t.LeadWorkerId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.JobPlanId)
                .Index(t => t.IssueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "SupervisorId", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "MaintenanceStatusId", "dbo.MaintenanceStatus");
            DropForeignKey("dbo.WorkOrders", "LeadWorkerId", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "JobPlanId", "dbo.JobPlans");
            DropForeignKey("dbo.WorkOrders", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.WorkOrders", "CreatorId", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "AssetInventoryId", "dbo.AssetInventories");
            DropIndex("dbo.WorkOrders", new[] { "IssueId" });
            DropIndex("dbo.WorkOrders", new[] { "JobPlanId" });
            DropIndex("dbo.WorkOrders", new[] { "AssetInventoryId" });
            DropIndex("dbo.WorkOrders", new[] { "LeadWorkerId" });
            DropIndex("dbo.WorkOrders", new[] { "SupervisorId" });
            DropIndex("dbo.WorkOrders", new[] { "MaintenanceStatusId" });
            DropIndex("dbo.WorkOrders", new[] { "CreatorId" });
            DropTable("dbo.WorkOrders");
        }
    }
}
