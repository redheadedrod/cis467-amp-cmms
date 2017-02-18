namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stockroom3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfItemsOrdered = c.Int(nullable: false),
                        OrderId_Id = c.Int(),
                        PartId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId_Id)
                .ForeignKey("dbo.SupplierPartIndexes", t => t.PartId_Id)
                .Index(t => t.OrderId_Id)
                .Index(t => t.PartId_Id);
            
            CreateTable(
                "dbo.OrderNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WhenEntered = c.DateTime(nullable: false),
                        Note = c.String(),
                        OrderId_Id = c.Int(),
                        WorkerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId_Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId_Id)
                .Index(t => t.OrderId_Id)
                .Index(t => t.WorkerId_Id);
            
            CreateTable(
                "dbo.RequestLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        RequestId_Id = c.Int(),
                        StockroomId_Id = c.Int(),
                        SupplierId_Id = c.Int(),
                        SupplierPartId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.RequestId_Id)
                .ForeignKey("dbo.StockroomInventories", t => t.StockroomId_Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId_Id)
                .ForeignKey("dbo.SupplierPartIndexes", t => t.SupplierPartId_Id)
                .Index(t => t.RequestId_Id)
                .Index(t => t.StockroomId_Id)
                .Index(t => t.SupplierId_Id)
                .Index(t => t.SupplierPartId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestLines", "SupplierPartId_Id", "dbo.SupplierPartIndexes");
            DropForeignKey("dbo.RequestLines", "SupplierId_Id", "dbo.Suppliers");
            DropForeignKey("dbo.RequestLines", "StockroomId_Id", "dbo.StockroomInventories");
            DropForeignKey("dbo.RequestLines", "RequestId_Id", "dbo.Requests");
            DropForeignKey("dbo.OrderNotes", "WorkerId_Id", "dbo.Workers");
            DropForeignKey("dbo.OrderNotes", "OrderId_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderLines", "PartId_Id", "dbo.SupplierPartIndexes");
            DropForeignKey("dbo.OrderLines", "OrderId_Id", "dbo.Orders");
            DropIndex("dbo.RequestLines", new[] { "SupplierPartId_Id" });
            DropIndex("dbo.RequestLines", new[] { "SupplierId_Id" });
            DropIndex("dbo.RequestLines", new[] { "StockroomId_Id" });
            DropIndex("dbo.RequestLines", new[] { "RequestId_Id" });
            DropIndex("dbo.OrderNotes", new[] { "WorkerId_Id" });
            DropIndex("dbo.OrderNotes", new[] { "OrderId_Id" });
            DropIndex("dbo.OrderLines", new[] { "PartId_Id" });
            DropIndex("dbo.OrderLines", new[] { "OrderId_Id" });
            DropTable("dbo.RequestLines");
            DropTable("dbo.OrderNotes");
            DropTable("dbo.OrderLines");
        }
    }
}
