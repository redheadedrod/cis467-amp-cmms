namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stockroom2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        OrderPlaced = c.DateTime(nullable: false),
                        OrderExpected = c.DateTime(nullable: false),
                        StatusLastUpDate = c.DateTime(nullable: false),
                        OrderApproved = c.Boolean(nullable: false),
                        OrderStatusId_Id = c.Int(),
                        SupplierContactId_Id = c.Int(),
                        SupplierId_Id = c.Int(),
                        WorkOrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId_Id)
                .ForeignKey("dbo.SupplierContacts", t => t.SupplierContactId_Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId_Id)
                .Index(t => t.OrderStatusId_Id)
                .Index(t => t.SupplierContactId_Id)
                .Index(t => t.SupplierId_Id)
                .Index(t => t.WorkOrderId_Id);
            
            CreateTable(
                "dbo.SupplierContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                        SupplierId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId_Id)
                .Index(t => t.SupplierId_Id);
            
            CreateTable(
                "dbo.SupplierPartIndexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        DateTimeOfLastPrice = c.DateTime(nullable: false),
                        DateTimePriceGoodUntil = c.DateTime(nullable: false),
                        PartNumber = c.String(),
                        StockRoomId_Id = c.Int(),
                        SupplierId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockroomInventories", t => t.StockRoomId_Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId_Id)
                .Index(t => t.StockRoomId_Id)
                .Index(t => t.SupplierId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierPartIndexes", "SupplierId_Id", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierPartIndexes", "StockRoomId_Id", "dbo.StockroomInventories");
            DropForeignKey("dbo.Orders", "WorkOrderId_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.Orders", "SupplierId_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "SupplierContactId_Id", "dbo.SupplierContacts");
            DropForeignKey("dbo.SupplierContacts", "SupplierId_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "OrderStatusId_Id", "dbo.OrderStatus");
            DropIndex("dbo.SupplierPartIndexes", new[] { "SupplierId_Id" });
            DropIndex("dbo.SupplierPartIndexes", new[] { "StockRoomId_Id" });
            DropIndex("dbo.SupplierContacts", new[] { "SupplierId_Id" });
            DropIndex("dbo.Orders", new[] { "WorkOrderId_Id" });
            DropIndex("dbo.Orders", new[] { "SupplierId_Id" });
            DropIndex("dbo.Orders", new[] { "SupplierContactId_Id" });
            DropIndex("dbo.Orders", new[] { "OrderStatusId_Id" });
            DropTable("dbo.SupplierPartIndexes");
            DropTable("dbo.SupplierContacts");
            DropTable("dbo.Orders");
        }
    }
}
