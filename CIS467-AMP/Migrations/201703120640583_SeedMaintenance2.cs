namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT IssueIndexes ON");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (0, 0, 0)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (1, 0, 1)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (2, 0, 2)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (3, 1, 0)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (4, 1, 1)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (5, 1, 2)");
            Sql("INSERT INTO IssueIndexes (Id, ClassOfissueId, IssueId) VALUES (6, 2, 2)");
            Sql("SET IDENTITY_INSERT IssueIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
