namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PartIndexes ON");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (0, 0 , 0, 1)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (1, 1 , 0, 2)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (2,  6, 1, 1)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (3,  7, 1, 2)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (4,  9, 2, 1)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (5,  10, 2, 2)");
            Sql("INSERT INTO PartIndexes (Id, PartsListIndexId, WorkOrderId, Number ) VALUES (6,  11, 2, 3)");
            Sql("SET IDENTITY_INSERT PartIndexes OFF");
            Sql("SET IDENTITY_INSERT WorkTimes ON");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, WorkerId, WorkOrderId) VALUES (0, 2017-3-1, 3, 0, 1)");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, WorkerId, WorkOrderId) VALUES (1, 2017-3-2, 2, 1, 2)");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, WorkerId, WorkOrderId) VALUES (2, 2017-3-2, 2, 2, 2)");
            Sql("SET IDENTITY_INSERT WorkTimes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
