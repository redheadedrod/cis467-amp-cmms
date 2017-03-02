namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateJobPlanDocuments : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT JobPlanDocuments ON");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlan_Id, Filename) VALUES (0,  0, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlan_Id, Filename) VALUES (1,  1, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlan_Id, Filename) VALUES (2,  2, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlan_Id, Filename) VALUES (3,  3, 'none' )");
            Sql("INSERT INTO JobPlanDocuments (Id, JobPlan_Id, Filename) VALUES (4,  4, 'none' )");

            Sql("SET IDENTITY_INSERT JobPlanDocuments OFF");
        }
        
        public override void Down()
        {
        }
    }
}
