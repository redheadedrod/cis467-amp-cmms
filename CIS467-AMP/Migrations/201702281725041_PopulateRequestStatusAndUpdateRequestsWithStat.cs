namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRequestStatusAndUpdateRequestsWithStat : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT RequestStatus ON");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (0, 'Waiting Approval')");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (1, 'Approved')");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (2, 'Waiting for items')");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (3, 'Complete, waiting for pickup')");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (4, 'Order Complete')");
            Sql("INSERT INTO RequestStatus (Id, Name) VALUES (5, 'Order Cancelled')");
            Sql("SET IDENTITY_INSERT RequestStatus OFF");
            Sql("UPDATE Requests SET RequestStatus_Id=0 WHERE Id=0");
            Sql("UPDATE Requests SET RequestStatus_Id=1 WHERE Id=1");
            Sql("UPDATE Requests SET RequestStatus_Id=3 WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
