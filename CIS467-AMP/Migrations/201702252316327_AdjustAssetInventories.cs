namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustAssetInventories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssetInventories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AssetInventories", "Name");
        }
    }
}
