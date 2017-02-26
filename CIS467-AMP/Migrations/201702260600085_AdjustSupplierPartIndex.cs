namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustSupplierPartIndex : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SupplierPartIndexes", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupplierPartIndexes", "Price", c => c.Int(nullable: false));
        }
    }
}
