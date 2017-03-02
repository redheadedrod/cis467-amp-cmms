namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateJobPlan : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT JobPlans ON");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, Variant_Id) VALUES (0,  'Seal replacement', 0 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, Variant_Id) VALUES (1,  'Seal replacement', 2 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, Variant_Id) VALUES (2,  'Seal replacement', 3 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, Variant_Id) VALUES (3,  'Seal replacement', 4 )");
            Sql("INSERT INTO JobPlans (Id, JobPlanName, Variant_Id) VALUES (4,  'Seal replacement', 5 )");
            Sql("SET IDENTITY_INSERT JobPlans OFF");
        }
        
        public override void Down()
        {
        }
    }
}
