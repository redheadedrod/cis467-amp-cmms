namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'48717f92-67e2-4c6e-b572-e07385c6ba1f', N'Administrator')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c62b5fea-15e1-4d1c-bf81-c3dbd19ef9d7', N'CanApproveOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'afd63757-1bef-4591-81aa-2368f5fcadef', N'CanApproveRequest')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f12b2c67-abf6-40b0-8883-ff5246c67a0d', N'CanApproveWorkOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1768cc66-eb4e-4cd0-bde7-c6b150895d9c', N'CanCreateLogbookEntry')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'87c2a91f-2a93-4dc9-93a6-7a2af89d8413', N'CanCreateOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c403dbd5-05a6-41e6-ad8d-28a99e81f5cc', N'CanCreateRequest')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'028a5615-9948-4083-8f7a-cc4684fc3093', N'CanCreateWorkOrder')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3bd149b1-8dec-4f68-80f9-508f66493fd5', N'CanEditWorkOrder')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
