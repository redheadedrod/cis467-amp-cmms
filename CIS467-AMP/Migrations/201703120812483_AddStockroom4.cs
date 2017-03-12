namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockroom4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        SupplierId = c.Int(nullable: false),
                        WorkOrderId = c.Int(nullable: false),
                        SupplierContactId = c.Int(nullable: false),
                        OrderPlaced = c.DateTime(nullable: false),
                        OrderExpected = c.DateTime(nullable: false),
                        StatusLastUpDate = c.DateTime(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                        OrderApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.SupplierContacts", t => t.SupplierContactId, cascadeDelete: false)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.WorkOrderId)
                .Index(t => t.SupplierContactId)
                .Index(t => t.OrderStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.Orders", "SupplierContactId", "dbo.SupplierContacts");
            DropForeignKey("dbo.Orders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "OrderStatusId", "dbo.OrderStatus");
            DropIndex("dbo.Orders", new[] { "OrderStatusId" });
            DropIndex("dbo.Orders", new[] { "SupplierContactId" });
            DropIndex("dbo.Orders", new[] { "WorkOrderId" });
            DropIndex("dbo.Orders", new[] { "SupplierId" });
            DropTable("dbo.Orders");
        }
    }
}
