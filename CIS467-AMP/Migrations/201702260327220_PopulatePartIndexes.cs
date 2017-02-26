namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePartIndexes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PartIndexes ON");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (0, 0 , 0, 1)");  
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (1, 1 , 0, 2)"); 
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (2,  6, 1, 1)");  
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (3,  7, 1, 2)"); 
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (4,  9, 2, 1)");  
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (5,  10, 2, 2)"); 
            Sql("INSERT INTO PartIndexes (Id, PartsListIndex_Id, WorkOrder_Id, Number ) VALUES (6,  11, 2, 3)"); 
            Sql("SET IDENTITY_INSERT PartIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
