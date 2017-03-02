namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateWorker : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "FirstName", c => c.String());
            AddColumn("dbo.Workers", "LastName", c => c.String());
            DropColumn("dbo.Workers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "Name", c => c.String());
            DropColumn("dbo.Workers", "LastName");
            DropColumn("dbo.Workers", "FirstName");
        }
    }
}
