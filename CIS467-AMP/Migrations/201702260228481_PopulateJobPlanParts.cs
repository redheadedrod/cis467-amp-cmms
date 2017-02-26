namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateJobPlanParts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT JobPlanParts ON");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (0, 0, 0 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (1, 0, 1 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (2, 1, 6 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (3, 1, 7 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (4, 2, 9 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (5, 2, 10 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (6, 2, 11 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (7, 3, 12 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (8, 3, 13 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (9, 3, 14 )");

            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (11, 4, 15 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (12, 4, 16 )");
            Sql("INSERT INTO JobPlanParts (Id, JobPlan_Id, Part_Id ) VALUES (13, 4, 17 )");



            Sql("SET IDENTITY_INSERT JobPlanParts OFF");
        }
        
        public override void Down()
        {
        }
    }
}
