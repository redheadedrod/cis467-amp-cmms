namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOrders : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Orders ON");
            Sql("INSERT INTO Orders (Id, OrderNumber, OrderPlaced, OrderExpected, StatusLastUpDate, OrderApproved, OrderStatus_Id, SupplierContact_Id, Supplier_Id, WorkOrder_Id) " +
                "VALUES (0, 'M-1001', 2017-3-1, 2017-3-16, 2017-3-3, 1, 3, 2,  1, 0)");
            Sql("INSERT INTO Orders (Id, OrderNumber, OrderPlaced, OrderExpected, StatusLastUpDate, OrderApproved, OrderStatus_Id, SupplierContact_Id, Supplier_Id, WorkOrder_Id) " +
                "VALUES (1, 'M-1002', 2017-3-2, 2017-3-15, 2017-5-3, 1, 0, 2,  1, 1)");
            Sql("INSERT INTO Orders (Id, OrderNumber, OrderPlaced, OrderExpected, StatusLastUpDate, OrderApproved, OrderStatus_Id, SupplierContact_Id, Supplier_Id, WorkOrder_Id) " +
                "VALUES (2, 'GR-1001', 2017-3-3, 2017-3-14, 2017-7-3, 1, 5, 0,  0, 2)");

            Sql("SET IDENTITY_INSERT Orders OFF");
        }
        
        public override void Down()
        {
        }
    }
}
