namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared1 : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT Manufacturers ON");
            Sql("INSERT INTO Manufacturers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (0, 'Gorman Rupp', '1313 Mockingbird Lane', 'Transalvania', 'New York', 'USA', '13131')");
            Sql("INSERT INTO Manufacturers (Id, Name, Address, City, Region, Country, PostalCode) VALUES (1, 'Moynal', '1357 Taco Lane', 'Little Town', 'North West', 'Mexico', '12343')");
            Sql("SET IDENTITY_INSERT Manufacturers OFF");
            Sql("SET IDENTITY_INSERT Maps ON");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (0, 'Grand rapids', 0 ,0 ,0)");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (1, 'Fulton', 0 ,0 ,0)");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (2, 'Market', 0 ,0 ,0)");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (3, 'Admin Building', 2 ,0 ,0)");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (4, 'Bathroom', 3 ,0 ,0)");
            Sql("INSERT INTO Maps (Id, Name, Parent, Longitude, Latitude) VALUES (5, 'Conference Room', 3 ,0 ,0)");
            Sql("SET IDENTITY_INSERT Maps OFF");
            Sql("SET IDENTITY_INSERT WorkGroups ON");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (0,  'Operations' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (1,  'Maintenance' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (2,  'Laboratory' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (3,  'Stockroom' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (4,  'Administration' )");
            Sql("SET IDENTITY_INSERT WorkGroups OFF");
        }
        
        public override void Down()
        {
        }
    }
}
