namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAssetTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AssetTypes ON");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (0, 'Pump', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (1, 'Valve', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (2, 'Piping', 0)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (3, 'Pump', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (4, 'Valve', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (5, 'Piping', 1)");
            Sql("INSERT INTO AssetTypes (Id, Name, Manufacturer_Id) VALUES (6, 'Motor', 1)");
            Sql("SET IDENTITY_INSERT AssetTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
