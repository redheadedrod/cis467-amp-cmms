namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance3 : DbMigration
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
            
            CreateTable(
                "dbo.MaintenanceWorkOrders",
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
                        JobPlanId = c.Int(),
                        MaintenanceIssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetInventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.CreatorId, cascadeDelete: true)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId)
                .ForeignKey("dbo.Workers", t => t.LeadWorkerId, cascadeDelete: false)
                .ForeignKey("dbo.MaintenanceIssues", t => t.MaintenanceIssueId, cascadeDelete: true)
                .ForeignKey("dbo.MaintenanceStatus", t => t.MaintenanceStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.SupervisorId, cascadeDelete: false)
                .Index(t => t.CreatorId)
                .Index(t => t.MaintenanceStatusId)
                .Index(t => t.SupervisorId)
                .Index(t => t.LeadWorkerId)
                .Index(t => t.AssetInventoryId)
                .Index(t => t.JobPlanId)
                .Index(t => t.MaintenanceIssueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintenanceWorkOrders", "SupervisorId", "dbo.Workers");
            DropForeignKey("dbo.MaintenanceWorkOrders", "MaintenanceStatusId", "dbo.MaintenanceStatus");
            DropForeignKey("dbo.MaintenanceWorkOrders", "MaintenanceIssueId", "dbo.MaintenanceIssues");
            DropForeignKey("dbo.MaintenanceWorkOrders", "LeadWorkerId", "dbo.Workers");
            DropForeignKey("dbo.MaintenanceWorkOrders", "JobPlanId", "dbo.JobPlans");
            DropForeignKey("dbo.MaintenanceWorkOrders", "CreatorId", "dbo.Workers");
            DropForeignKey("dbo.MaintenanceWorkOrders", "AssetInventoryId", "dbo.AssetInventories");
            DropForeignKey("dbo.MaintenanceIssueIndexes", "MaintenanceIssueId", "dbo.MaintenanceIssues");
            DropForeignKey("dbo.MaintenanceIssueIndexes", "MaintenanceClassOfIssueId", "dbo.MaintenanceClassOfIssues");
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "MaintenanceIssueId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "JobPlanId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "AssetInventoryId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "LeadWorkerId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "SupervisorId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "MaintenanceStatusId" });
            DropIndex("dbo.MaintenanceWorkOrders", new[] { "CreatorId" });
            DropIndex("dbo.MaintenanceIssueIndexes", new[] { "MaintenanceIssueId" });
            DropIndex("dbo.MaintenanceIssueIndexes", new[] { "MaintenanceClassOfIssueId" });
            DropTable("dbo.MaintenanceWorkOrders");
            DropTable("dbo.MaintenanceIssueIndexes");
        }
    }
}
