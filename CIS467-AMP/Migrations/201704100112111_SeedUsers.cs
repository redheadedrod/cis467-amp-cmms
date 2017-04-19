namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'05b85ad1-f4c0-4c01-83e0-50ba54cf8f68', N'guest@amp.com', 0, N'ACtc8jzNblup0BAWWtGfN45An/cxbEWGfIgmAHzozvuKAG40ZMkbINXSMljebAmKGg==', N'36df427c-7ff6-40b7-a1e3-a97033609364', NULL, 0, 0, NULL, 1, 0, N'guest@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d0984ef-c38a-49b5-b8d8-213695c994fc', N'mechanic@amp.com', 0, N'ANnEZbjwxom1I/Vun/XcGFKwTJncdr2IkrGu1CH0HinqrS+CblBWg45WBIDSP9mlGg==', N'b91fc9f8-70f4-457a-bb1a-21bfe24e9587', NULL, 0, 0, NULL, 1, 0, N'mechanic@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7408510c-1ef8-40e8-8c2b-f62e96c95964', N'admin@amp.com', 0, N'AJU9xdCXDINLoQNsFJ6C5oVp1ebDY3c785AOmCc7avT+0+MriX1GNXa3oHRAa3y+BQ==', N'b940704f-0ef2-4753-a62b-4e292ba8b573', NULL, 0, 0, NULL, 1, 0, N'admin@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'773b72df-8871-4a0b-bc52-596d1683bed8', N'supervisor@amp.com', 0, N'ALINJRmwxq0Oj9NjBWeElsIGyIpgdaTdt7nYYealpGORk4+8s79yk9ffungMsuFbkA==', N'f87d1a94-833d-436d-92e7-47298e7d2c2c', NULL, 0, 0, NULL, 1, 0, N'supervisor@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4de8697-195f-4a77-a56d-718cddc4a971', N'operator@amp.com', 0, N'AFJTPZkSJJlucCwB6LQ3pYw3hY/phOdblG1aL1yptCW0GYX0M+EQBb9Y0uCm9bZr8A==', N'7b8e1b5d-11ed-43bc-9a03-8dbbab1a6be3', NULL, 0, 0, NULL, 1, 0, N'operator@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee8759b9-31eb-4acc-aa34-b7266e490427', N'stockroom@amp.com', 0, N'AKS/r6mZe7+7liKi9wGWyb7yF+71OPsBaOU4vAvX6BZaFCTJfn/6Fv0xgiPKPr37TQ==', N'72e5d0ba-68e6-420c-9afe-f97d3fd51659', NULL, 0, 0, NULL, 1, 0, N'stockroom@amp.com')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
