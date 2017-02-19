namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maintenance1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassOfIssues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        PartsIndex_Id = c.Int(),
                        WorkOrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartsListIndexes", t => t.PartsIndex_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId_Id)
                .Index(t => t.PartsIndex_Id)
                .Index(t => t.WorkOrderId_Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastStatusDateTime = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        ShortDesc = c.String(),
                        LongDesc = c.String(),
                        AssetId_Id = c.Int(),
                        CreatorId_Id = c.Int(),
                        IssueId_Id = c.Int(),
                        JobPlanId_Id = c.Int(),
                        LeadWorkerId_Id = c.Int(),
                        StatusId_Id = c.Int(),
                        SupervisorId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetInventories", t => t.AssetId_Id)
                .ForeignKey("dbo.Workers", t => t.CreatorId_Id)
                .ForeignKey("dbo.Issues", t => t.IssueId_Id)
                .ForeignKey("dbo.JobPlans", t => t.JobPlanId_Id)
                .ForeignKey("dbo.Workers", t => t.LeadWorkerId_Id)
                .ForeignKey("dbo.MaintenanceStatus", t => t.StatusId_Id)
                .ForeignKey("dbo.Workers", t => t.SupervisorId_Id)
                .Index(t => t.AssetId_Id)
                .Index(t => t.CreatorId_Id)
                .Index(t => t.IssueId_Id)
                .Index(t => t.JobPlanId_Id)
                .Index(t => t.LeadWorkerId_Id)
                .Index(t => t.StatusId_Id)
                .Index(t => t.SupervisorId_Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IssueClass_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassOfIssues", t => t.IssueClass_Id)
                .Index(t => t.IssueClass_Id);
            
            CreateTable(
                "dbo.MaintenanceStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaintenanceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PartIndexes", "WorkOrderId_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkOrders", "SupervisorId_Id", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "StatusId_Id", "dbo.MaintenanceStatus");
            DropForeignKey("dbo.WorkOrders", "LeadWorkerId_Id", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "JobPlanId_Id", "dbo.JobPlans");
            DropForeignKey("dbo.WorkOrders", "IssueId_Id", "dbo.Issues");
            DropForeignKey("dbo.Issues", "IssueClass_Id", "dbo.ClassOfIssues");
            DropForeignKey("dbo.WorkOrders", "CreatorId_Id", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "AssetId_Id", "dbo.AssetInventories");
            DropForeignKey("dbo.PartIndexes", "PartsIndex_Id", "dbo.PartsListIndexes");
            DropIndex("dbo.Issues", new[] { "IssueClass_Id" });
            DropIndex("dbo.WorkOrders", new[] { "SupervisorId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "StatusId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "LeadWorkerId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "JobPlanId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "IssueId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "CreatorId_Id" });
            DropIndex("dbo.WorkOrders", new[] { "AssetId_Id" });
            DropIndex("dbo.PartIndexes", new[] { "WorkOrderId_Id" });
            DropIndex("dbo.PartIndexes", new[] { "PartsIndex_Id" });
            DropTable("dbo.MaintenanceTypes");
            DropTable("dbo.MaintenanceStatus");
            DropTable("dbo.Issues");
            DropTable("dbo.WorkOrders");
            DropTable("dbo.PartIndexes");
            DropTable("dbo.ClassOfIssues");
        }
    }
}
