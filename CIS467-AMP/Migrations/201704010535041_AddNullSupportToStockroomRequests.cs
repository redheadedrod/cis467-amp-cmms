namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullSupportToStockroomRequests : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StockRoomRequests", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropForeignKey("dbo.StockRoomRequests", "StockRoomRequestStatusId", "dbo.StockRoomRequestStatus");
            DropForeignKey("dbo.StockRoomRequests", "WorkerId", "dbo.Workers");
            DropIndex("dbo.StockRoomRequests", new[] { "WorkerId" });
            DropIndex("dbo.StockRoomRequests", new[] { "MaintenanceWorkOrderId" });
            DropIndex("dbo.StockRoomRequests", new[] { "StockRoomRequestStatusId" });
            AlterColumn("dbo.StockRoomRequests", "WorkerId", c => c.Int());
            AlterColumn("dbo.StockRoomRequests", "MaintenanceWorkOrderId", c => c.Int());
            AlterColumn("dbo.StockRoomRequests", "StockRoomRequestStatusId", c => c.Int());
            CreateIndex("dbo.StockRoomRequests", "WorkerId");
            CreateIndex("dbo.StockRoomRequests", "MaintenanceWorkOrderId");
            CreateIndex("dbo.StockRoomRequests", "StockRoomRequestStatusId");
            AddForeignKey("dbo.StockRoomRequests", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders", "Id");
            AddForeignKey("dbo.StockRoomRequests", "StockRoomRequestStatusId", "dbo.StockRoomRequestStatus", "Id");
            AddForeignKey("dbo.StockRoomRequests", "WorkerId", "dbo.Workers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockRoomRequests", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.StockRoomRequests", "StockRoomRequestStatusId", "dbo.StockRoomRequestStatus");
            DropForeignKey("dbo.StockRoomRequests", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders");
            DropIndex("dbo.StockRoomRequests", new[] { "StockRoomRequestStatusId" });
            DropIndex("dbo.StockRoomRequests", new[] { "MaintenanceWorkOrderId" });
            DropIndex("dbo.StockRoomRequests", new[] { "WorkerId" });
            AlterColumn("dbo.StockRoomRequests", "StockRoomRequestStatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.StockRoomRequests", "MaintenanceWorkOrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.StockRoomRequests", "WorkerId", c => c.Int(nullable: false));
            CreateIndex("dbo.StockRoomRequests", "StockRoomRequestStatusId");
            CreateIndex("dbo.StockRoomRequests", "MaintenanceWorkOrderId");
            CreateIndex("dbo.StockRoomRequests", "WorkerId");
            AddForeignKey("dbo.StockRoomRequests", "WorkerId", "dbo.Workers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StockRoomRequests", "StockRoomRequestStatusId", "dbo.StockRoomRequestStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StockRoomRequests", "MaintenanceWorkOrderId", "dbo.MaintenanceWorkOrders", "Id", cascadeDelete: true);
        }
    }
}
