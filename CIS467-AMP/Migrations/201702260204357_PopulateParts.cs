namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateParts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Parts ON");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (0, 'GR-0104' ,'4 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (1, 'GR-0204' ,'4 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (2, 'GR-0304' ,'4 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (3, 'GR-0108' ,'8 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (4, 'GR-0208' ,'8 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (5, 'GR-0308' ,'8 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (6, 'GR-0112' ,'12 inch Inner Seal' , 0, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (7, 'GR-0212' ,'12 inch Outer Seal' , 0, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (8, 'GR-0312' ,'12 inch Shaft' , 0, 2 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (9, 'M-0104' ,'4 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (10, 'M-0204' ,'4 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (11, 'M-0304' ,'4 inch Shaft' , 1, 2 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (12, 'M-0108' ,'8 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (13, 'M-0208' ,'8 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (14, 'M-0308' ,'8 inch Shaft' , 1, 2 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (15, 'M-0112' ,'12 inch Inner Seal' , 1, 0 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (16, 'M-0212' ,'12 inch Outer Seal' , 1, 1 )");
            Sql("INSERT INTO Parts (Id, Number, Name, Manufacturer_Id, PartType_Id ) VALUES (17, 'M-0312' ,'12 inch Shaft' , 1, 2 )");
            Sql("SET IDENTITY_INSERT Parts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
