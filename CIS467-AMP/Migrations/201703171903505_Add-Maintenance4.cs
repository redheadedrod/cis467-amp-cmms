namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaintenance4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaintenanceWorkOrderPartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaintenanceWorkOrderId = c.Int(nullable: false),
                        ManufacturerToVariantPartIndexId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaintenanceWorkOrders", t => t.MaintenanceWorkOrderId, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerToVariantPartIndexes", t => t.ManufacturerToVariantPartIndexId, cascadeDelete: false)
                .Index(t => t.MaintenanceWorkOrderId)
                .Index(t => t.ManufacturerToVariantPartIndexId);
            
            CreateTable(
                "dbo.MaintenanceWorkOrderWorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        HoursWorked = c.Int(nullable: false),
                        MaintenanceWorkOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaintenanceWorkOrders", t => t.MaintenanceWorkOrderId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: false)
                .Index(t => t.WorkerId)
                .Index(t => t.MaintenanceWorkOrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintenanceWorkOrderWorkTimes", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.MaintenanceWorkOrderWorkTimes", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropForeignKey("dbo.MaintenanceWorkOrderPartIndexes", "ManufacturerToVariantPartIndexId", "dbo.ManufacturerToVariantPartIndexes");
            DropForeignKey("dbo.MaintenanceWorkOrderPartIndexes", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropIndex("dbo.MaintenanceWorkOrderWorkTimes", new[] { "MaintenanceWorkOrderId" });
            DropIndex("dbo.MaintenanceWorkOrderWorkTimes", new[] { "WorkerId" });
            DropIndex("dbo.MaintenanceWorkOrderPartIndexes", new[] { "ManufacturerToVariantPartIndexId" });
            DropIndex("dbo.MaintenanceWorkOrderPartIndexes", new[] { "MaintenanceWorkOrderId" });
            DropTable("dbo.MaintenanceWorkOrderWorkTimes");
            DropTable("dbo.MaintenanceWorkOrderPartIndexes");
        }
    }
}
