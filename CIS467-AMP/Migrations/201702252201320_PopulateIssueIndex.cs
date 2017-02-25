namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateIssueIndex : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT IssueIndexes ON");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (0, 0, 0)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (1, 0, 1)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (2, 0, 2)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (3, 1, 0)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (4, 1, 1)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (5, 1, 2)");
            Sql("INSERT INTO IssueIndexes (Id, Class_Id, Issue_Id) VALUES (6, 2, 2)");
            Sql("SET IDENTITY_INSERT IssueIndexes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
