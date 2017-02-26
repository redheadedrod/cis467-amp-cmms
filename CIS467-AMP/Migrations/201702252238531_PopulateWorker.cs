namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWorker : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Workers ON");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (0, 4,  'Moe', 'Howard', 'H1234', '555-555-1234', 'MoeH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (1, 0,  'Curly', 'Howard', 'H2345', '555-555-2345', 'CurlyH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (2, 1,  'Shemp', 'Howard', 'H3456', '555-555-3456', 'ShempH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (3, 1,  'Larry', 'Fine', 'F4567', '555-555-4567', 'LarryH@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (4, 2,  'Joe', 'DeRita', 'D5678', '555-555-5678', 'JoeD@3stooges.com' )");
            Sql("INSERT INTO Workers (Id, WorkGroup_Id, FirstName, LastName, Employee, PhoneNumber, EmailAddress ) VALUES (5, 3,  'Joe', 'Besser', 'B6789', '555-555-6789', 'JoeBMoe@3stooges.com' )");
            Sql("SET IDENTITY_INSERT Workers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
