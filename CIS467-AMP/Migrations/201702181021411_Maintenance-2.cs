namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maintenance2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        HoursWorked = c.Int(nullable: false),
                        WorkerId_Id = c.Int(),
                        WorkOrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId_Id)
                .Index(t => t.WorkerId_Id)
                .Index(t => t.WorkOrderId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkTimes", "WorkOrderId_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkTimes", "WorkerId_Id", "dbo.Workers");
            DropIndex("dbo.WorkTimes", new[] { "WorkOrderId_Id" });
            DropIndex("dbo.WorkTimes", new[] { "WorkerId_Id" });
            DropTable("dbo.WorkTimes");
        }
    }
}
