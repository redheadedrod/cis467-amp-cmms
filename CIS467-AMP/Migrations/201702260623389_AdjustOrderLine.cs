namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustOrderLine : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderLines", name: "Part_Id", newName: "SupplierPartIndex_Id");
            RenameIndex(table: "dbo.OrderLines", name: "IX_Part_Id", newName: "IX_SupplierPartIndex_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.OrderLines", name: "IX_SupplierPartIndex_Id", newName: "IX_Part_Id");
            RenameColumn(table: "dbo.OrderLines", name: "SupplierPartIndex_Id", newName: "Part_Id");
        }
    }
}
