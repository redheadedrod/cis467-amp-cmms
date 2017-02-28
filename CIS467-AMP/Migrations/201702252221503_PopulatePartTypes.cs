namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePartTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PartTypes ON");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (0, 'Inner Seal')");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (1, 'Outer Seal')");
            Sql("INSERT INTO PartTypes (Id, Name) VALUES (2, 'Shaft')");
            Sql("SET IDENTITY_INSERT PartTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
