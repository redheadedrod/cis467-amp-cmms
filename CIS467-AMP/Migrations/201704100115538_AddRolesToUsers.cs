namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRolesToUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d0984ef-c38a-49b5-b8d8-213695c994fc', N'028a5615-9948-4083-8f7a-cc4684fc3093')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'028a5615-9948-4083-8f7a-cc4684fc3093')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4de8697-195f-4a77-a56d-718cddc4a971', N'028a5615-9948-4083-8f7a-cc4684fc3093')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee8759b9-31eb-4acc-aa34-b7266e490427', N'028a5615-9948-4083-8f7a-cc4684fc3093')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d0984ef-c38a-49b5-b8d8-213695c994fc', N'1768cc66-eb4e-4cd0-bde7-c6b150895d9c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'1768cc66-eb4e-4cd0-bde7-c6b150895d9c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4de8697-195f-4a77-a56d-718cddc4a971', N'1768cc66-eb4e-4cd0-bde7-c6b150895d9c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee8759b9-31eb-4acc-aa34-b7266e490427', N'1768cc66-eb4e-4cd0-bde7-c6b150895d9c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d0984ef-c38a-49b5-b8d8-213695c994fc', N'3bd149b1-8dec-4f68-80f9-508f66493fd5')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'3bd149b1-8dec-4f68-80f9-508f66493fd5')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7408510c-1ef8-40e8-8c2b-f62e96c95964', N'48717f92-67e2-4c6e-b572-e07385c6ba1f')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'87c2a91f-2a93-4dc9-93a6-7a2af89d8413')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee8759b9-31eb-4acc-aa34-b7266e490427', N'87c2a91f-2a93-4dc9-93a6-7a2af89d8413')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'afd63757-1bef-4591-81aa-2368f5fcadef')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d0984ef-c38a-49b5-b8d8-213695c994fc', N'c403dbd5-05a6-41e6-ad8d-28a99e81f5cc')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'c403dbd5-05a6-41e6-ad8d-28a99e81f5cc')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4de8697-195f-4a77-a56d-718cddc4a971', N'c403dbd5-05a6-41e6-ad8d-28a99e81f5cc')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'c62b5fea-15e1-4d1c-bf81-c3dbd19ef9d7')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'f12b2c67-abf6-40b0-8883-ff5246c67a0d')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
