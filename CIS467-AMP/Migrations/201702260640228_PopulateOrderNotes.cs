namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOrderNotes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT OrderNotes ON");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, Order_Id, Worker_Id) VALUES (0, 2017-12-12, 'Placed order on 2/23/2017', 0, 0)");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, Order_Id, Worker_Id) VALUES (1, 2017-12-13, 'Order Checked in on 2/23/2017', 2, 3)");
            Sql("INSERT INTO OrderNotes (Id, WhenEntered, Note, Order_Id, Worker_Id) VALUES (2, 2017-1-1, 'Placed order on 1/1/2017', 1, 2)");
            Sql("SET IDENTITY_INSERT OrderNotes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
