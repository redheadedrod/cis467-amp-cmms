namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSupplier : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Suppliers ON");
            Sql("INSERT INTO Suppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (0, 'Grainger', '1234 Somewhere', 'Nearby', 'Mi', 'USA', '49494')");
            Sql("INSERT INTO Suppliers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (1, 'Meijer', '1313 Walker', 'Grand Rapids', 'Mi', 'USA', '49513')");
            Sql("SET IDENTITY_INSERT Suppliers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
