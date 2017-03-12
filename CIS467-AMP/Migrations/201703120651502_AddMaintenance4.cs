namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkOrderId = c.Int(nullable: false),
                        PartsListIndexId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartsListIndexes", t => t.PartsListIndexId, cascadeDelete: true)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: false)
                .Index(t => t.WorkOrderId)
                .Index(t => t.PartsListIndexId);
            
            CreateTable(
                "dbo.WorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        HoursWorked = c.Int(nullable: false),
                        WorkOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: false)
                .Index(t => t.WorkerId)
                .Index(t => t.WorkOrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkTimes", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkTimes", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.PartIndexes", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.PartIndexes", "PartsListIndexId", "dbo.PartsListIndexes");
            DropIndex("dbo.WorkTimes", new[] { "WorkOrderId" });
            DropIndex("dbo.WorkTimes", new[] { "WorkerId" });
            DropIndex("dbo.PartIndexes", new[] { "PartsListIndexId" });
            DropIndex("dbo.PartIndexes", new[] { "WorkOrderId" });
            DropTable("dbo.WorkTimes");
            DropTable("dbo.PartIndexes");
        }
    }
}
