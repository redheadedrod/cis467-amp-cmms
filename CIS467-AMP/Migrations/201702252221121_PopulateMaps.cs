namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMaps : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Maps ON");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (0, 'Grand rapids', 0)");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (1, 'Fulton', 0)");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (2, 'Market', 0)");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (3, 'Admin Building', 2)");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (4, 'Bathroom', 3)");
            Sql("INSERT INTO Maps (Id, Name, Parent) VALUES (5, 'Conference Room', 3)");
            Sql("SET IDENTITY_INSERT Maps OFF");
        }
        
        public override void Down()
        {
        }
    }
}
