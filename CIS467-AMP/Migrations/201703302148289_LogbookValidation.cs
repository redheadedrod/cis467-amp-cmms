namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogbookValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogbookGenerals", "Entry", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogbookGenerals", "Entry", c => c.String());
        }
    }
}
