namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedShared5 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT WorkGroupSupervisors ON");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (0,  4,  0)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (1,  4,  1)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (2,  4,  2)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (3,  5,  3)");
            Sql("INSERT INTO WorkGroupSupervisors (Id, WorkerId, WorkGroupId ) VALUES (4,  5,  4)");
            Sql("SET IDENTITY_INSERT WorkGroupSupervisors OFF");
        }
        
        public override void Down()
        {
        }
    }
}
