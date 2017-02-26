namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufacturer : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Manufacturers ON");
            Sql("INSERT INTO Manufacturers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (0, 'Gorman Rupp', '1313 Mockingbird Lane', 'Transalvania', 'New York', 'USA', '13131')");
            Sql("INSERT INTO Manufacturers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (1, 'Moynal', '1357 Taco Lane', 'Little Town', 'North West', 'Mexico', '12343')");
            Sql("SET IDENTITY_INSERT Manufacturers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
