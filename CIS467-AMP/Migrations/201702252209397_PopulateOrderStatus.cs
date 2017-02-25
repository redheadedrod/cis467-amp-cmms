namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOrderStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT OrderStatus ON");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (0, 'Placed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (1, 'Closed - Completed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (2, 'Closed')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (3, 'In Transit')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (4, 'Waiting for approval')");
            Sql("INSERT INTO OrderStatus (Id, Name) VALUES (5, 'Recieved - to be checked in yet')");
            Sql("SET IDENTITY_INSERT OrderStatus OFF");
        }
        
        public override void Down()
        {
        }
    }
}
