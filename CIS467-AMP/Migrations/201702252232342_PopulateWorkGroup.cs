namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWorkGroup : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT WorkGroups ON");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (0,  'Operations' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (1,  'Maintenance' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (2,  'Laboratory' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (3,  'Stockroom' )");
            Sql("INSERT INTO WorkGroups (Id, Name ) VALUES (4,  'Administration' )");
            Sql("SET IDENTITY_INSERT WorkGroups OFF");
        }
        
        public override void Down()
        {
        }
    }
}
