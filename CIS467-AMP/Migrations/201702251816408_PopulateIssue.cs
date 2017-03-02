namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateIssue : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Issues ON");
            Sql("INSERT INTO Issues (Id, Name) VALUES (0, 'Leak')");
            Sql("INSERT INTO Issues (Id, Name) VALUES (1, 'Loose')");
            Sql("INSERT INTO Issues (Id, Name) VALUES (2, 'Failed')");
            Sql("SET IDENTITY_INSERT Issues OFF");
        }
        
        public override void Down()
        {
        }
    }
}
