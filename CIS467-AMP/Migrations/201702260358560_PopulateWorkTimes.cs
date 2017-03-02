namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWorkTimes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT WorkTimes ON");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, Worker_Id, WorkOrder_Id) VALUES (0, 2017-3-1, 3, 0, 1)");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, Worker_Id, WorkOrder_Id) VALUES (1, 2017-3-2, 2, 1, 2)");
            Sql("INSERT INTO WorkTimes (Id, StartTime, HoursWorked, Worker_Id, WorkOrder_Id) VALUES (2, 2017-3-2, 2, 2, 2)");
            Sql("SET IDENTITY_INSERT WorkTimes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
