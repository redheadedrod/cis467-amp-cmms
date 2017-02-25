namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatelogbooktypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT LogbookTypes ON");
            Sql("INSERT INTO LogbookTypes (Id, Name) VALUES (0, 'General')");
            Sql("INSERT INTO LogbookTypes (Id, Name) VALUES (1, 'Maintenance')");
            Sql("INSERT INTO LogbookTypes (Id, Name) VALUES (2, 'Stockroom')");
            Sql("SET IDENTITY_INSERT LogbookTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
