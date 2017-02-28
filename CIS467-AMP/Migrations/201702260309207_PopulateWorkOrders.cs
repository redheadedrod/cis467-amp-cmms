namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWorkOrders : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT WorkOrders ON");
            Sql("INSERT INTO WorkOrders (Id, Creator_Id, CreatedDateTime, MaintenanceStatus_Id, LastStatusDateTime, Priority, Supervisor_Id, LeadWorker_Id,  AssetInventory_Id, JobPlan_Id, Issue_Id, ShortDesc, LongDesc ) " +
                "VALUES (0, 0, 02/25/2017,  0, 02/26/2017, 5, 4, 2, 0, 0, 0, 'Seal leak', 'Seal Leak - Repair')");
            Sql("INSERT INTO WorkOrders (Id, Creator_Id, CreatedDateTime, MaintenanceStatus_Id, LastStatusDateTime, Priority, Supervisor_Id, LeadWorker_Id,  AssetInventory_Id, JobPlan_Id, Issue_Id, ShortDesc, LongDesc ) " +
                "VALUES (1, 1, 02/26/2017,  1, 02/28/2017, 5, 4, 1, 2, 1, 0, 'Seal leaker', 'Seal Leaker - Repair')");
            Sql("INSERT INTO WorkOrders (Id, Creator_Id, CreatedDateTime, MaintenanceStatus_Id, LastStatusDateTime, Priority, Supervisor_Id, LeadWorker_Id,  AssetInventory_Id, JobPlan_Id, Issue_Id, ShortDesc, LongDesc ) " +
                "VALUES (2, 3, 02/27/2017, 3 , 02/28/2017, 5, 4, 0, 3, 2, 0, 'Seal leaked', 'Seal Leaked - Repair')");

            Sql("SET IDENTITY_INSERT WorkOrders OFF");
        }
        
        public override void Down()
        {
        }
    }
}
