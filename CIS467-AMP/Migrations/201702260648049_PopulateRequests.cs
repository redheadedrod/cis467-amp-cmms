namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRequests : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Requests ON");
            Sql("INSERT INTO Requests (Id, Worker_Id, WorkOrder_Id, Asset_Id, Requested, Required, Approval) VALUES (0, 1, 0, 0, 12-12-2017, 12-23-2017, 1)");
            Sql("INSERT INTO Requests (Id, Worker_Id, WorkOrder_Id, Asset_Id, Requested, Required, Approval) VALUES (1, 2, 1, 2, 12-12-2017, 12-23-2017, 1)");
            Sql("INSERT INTO Requests (Id, Worker_Id, WorkOrder_Id, Asset_Id, Requested, Required, Approval) VALUES (2, 0, 2, 3, 12-12-2017, 12-23-2017, 0)");

            Sql("SET IDENTITY_INSERT Requests OFF");
        }
        
        public override void Down()
        {
        }
    }
}
