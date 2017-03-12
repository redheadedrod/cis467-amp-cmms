namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockroom5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        SupplierPartIndexId = c.Int(nullable: false),
                        NumberOfItemsOrdered = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.SupplierPartIndexes", t => t.SupplierPartIndexId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.SupplierPartIndexId);
            
            CreateTable(
                "dbo.OrderNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        WhenEntered = c.DateTime(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: false)
                .Index(t => t.OrderId)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderNotes", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.OrderNotes", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderLines", "SupplierPartIndexId", "dbo.SupplierPartIndexes");
            DropForeignKey("dbo.OrderLines", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderNotes", new[] { "WorkerId" });
            DropIndex("dbo.OrderNotes", new[] { "OrderId" });
            DropIndex("dbo.OrderLines", new[] { "SupplierPartIndexId" });
            DropIndex("dbo.OrderLines", new[] { "OrderId" });
            DropTable("dbo.OrderNotes");
            DropTable("dbo.OrderLines");
        }
    }
}
