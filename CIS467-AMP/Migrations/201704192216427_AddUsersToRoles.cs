namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersToRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'1df70a0c-f995-4d07-889a-be4fec95e0e0', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'ab295407-238e-4a5a-b8c0-460208d5d8fe', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'dd976176-6551-4bd4-97e5-05cf4d021d21', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f2fe0c77-552b-40b6-8e3c-0277ecf8cd04', N'0a0a20ec-6ef5-49e6-8a13-a9a530384b69')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'1df70a0c-f995-4d07-889a-be4fec95e0e0', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'ab295407-238e-4a5a-b8c0-460208d5d8fe', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'dd976176-6551-4bd4-97e5-05cf4d021d21', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f2fe0c77-552b-40b6-8e3c-0277ecf8cd04', N'14bf0cc1-1a82-4c58-8710-d6ccf3f4f0b3')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'3a7878a9-ef04-4c8d-8148-9cd35f213892', N'163b2023-1b4b-4670-a4cc-14dab6117903')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'47f7af31-6c95-4bb4-8751-88c4c032b4bd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'47f7af31-6c95-4bb4-8751-88c4c032b4bd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'49e25e10-75d1-4b41-9a53-f8a5c28f2016')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'ab295407-238e-4a5a-b8c0-460208d5d8fe', N'49e25e10-75d1-4b41-9a53-f8a5c28f2016')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'49e25e10-75d1-4b41-9a53-f8a5c28f2016')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'1df70a0c-f995-4d07-889a-be4fec95e0e0', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'ab295407-238e-4a5a-b8c0-460208d5d8fe', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'dd976176-6551-4bd4-97e5-05cf4d021d21', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f2fe0c77-552b-40b6-8e3c-0277ecf8cd04', N'6335015f-3ab5-430f-b919-f4337df6ffdd')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'd859293c-dc5d-41a4-ba1a-4211572e2e6b')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'd859293c-dc5d-41a4-ba1a-4211572e2e6b')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'e72474c2-553f-44b9-895b-0e8ed209bed7')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'e72474c2-553f-44b9-895b-0e8ed209bed7')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'19eb7194-592c-4363-a657-cc422193284e', N'f3c3e6e6-f7c7-4169-90e6-59b4a35ed525')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'1df70a0c-f995-4d07-889a-be4fec95e0e0', N'f3c3e6e6-f7c7-4169-90e6-59b4a35ed525')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f1649356-320f-4344-ba3d-54a62465a483', N'f3c3e6e6-f7c7-4169-90e6-59b4a35ed525')
INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'f2fe0c77-552b-40b6-8e3c-0277ecf8cd04', N'f3c3e6e6-f7c7-4169-90e6-59b4a35ed525')
");
        }

    public override void Down()
        {
        }
    }
}
