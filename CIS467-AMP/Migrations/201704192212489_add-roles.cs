namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addroles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'163b2023-1b4b-4670-a4cc-14dab6117903', N'Administrator')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'47f7af31-6c95-4bb4-8751-88c4c032b4bd', N'CanApproveOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e72474c2-553f-44b9-895b-0e8ed209bed7', N'CanApproveRequest')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd859293c-dc5d-41a4-ba1a-4211572e2e6b', N'CanApproveWorkOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6335015f-3ab5-430f-b919-f4337df6ffdd', N'CanCreateLogbookEntry')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'49e25e10-75d1-4b41-9a53-f8a5c28f2016', N'CanCreateOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3', N'CanCreateRequest')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69', N'CanCreateWorkOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f3c3e6e6-f7c7-4169-90e6-59b4a35ed525', N'CanEditWorkOrder')
");
        }
        
        public override void Down()
        {
        }
    }
}
