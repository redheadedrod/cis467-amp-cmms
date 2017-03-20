namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldtoJobPlanParts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobPlanParts", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobPlanParts", "Number");
        }
    }
}
