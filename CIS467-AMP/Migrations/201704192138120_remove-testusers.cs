namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removetestusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                DELETE  FROM [dbo].[AspNetUsers]
                DELETE  FROM [dbo].[AspNetRoles] 
            ");
        }
        
        public override void Down()
        {
        }
    }
}
