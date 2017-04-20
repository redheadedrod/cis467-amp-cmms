namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers3stooges : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19eb7194-592c-4363-a657-cc422193284e', N'JoeBMoe@3stooges.com', 0, N'AOp+O9RsTM1/PCOmQM+YQHkmWlmM+h7XRAzPzsO+F7t+W6MYAsbiTrTjSyULlSMSiw==', N'cd0382ab-af0a-4b6f-b479-498159865c8e', NULL, 0, 0, NULL, 1, 0, N'JoeBMoe@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1df70a0c-f995-4d07-889a-be4fec95e0e0', N'CurlyH@3stooges.com', 0, N'ANewGrLJMsif7DQzL8eHr++jkfWP2sPYbT/M1a8Z18WJLHJrulRKhnQCZEl0MqtIvQ==', N'b33d7167-3ee7-42d4-af91-e50189c08962', NULL, 0, 0, NULL, 1, 0, N'CurlyH@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a7878a9-ef04-4c8d-8148-9cd35f213892', N'Admin@amp.com', 0, N'AEx8nlL9qcA/qHQQYSWqMsvZ8rr0EH839zU0oz4rgm1W/1NDtWDgm4ck9tQAe5zbnw==', N'ee1d6030-42c3-46ba-8067-b0acb507789d', NULL, 0, 0, NULL, 1, 0, N'Admin@amp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ab295407-238e-4a5a-b8c0-460208d5d8fe', N'LarryH@3stooges.com', 0, N'AMSCxyve61tUIosVISDs8vjzDQbfsi4cT0zvh6bickgEkAyA8FBtFFnmk5ZUv9Azsw==', N'cee7f50d-a420-486b-b302-640fa12ad636', NULL, 0, 0, NULL, 1, 0, N'LarryH@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dd976176-6551-4bd4-97e5-05cf4d021d21', N'MoeH@3stooges.com', 0, N'AGBzguQCYYJwaAYklABXLcWfFRGElMD7zq2MxknbDZXDSq47kEQD86ypoG2yZeWSlw==', N'15852327-59de-4f37-badd-c12d2f0d7296', NULL, 0, 0, NULL, 1, 0, N'MoeH@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f1649356-320f-4344-ba3d-54a62465a483', N'JoeD@3stooges.com', 0, N'AI24M9DX76a0dKF7Qs0TnIQ4mdjlVnZBrOZ7Xan/9KSkq5uD0efVngFSYuzBH13itQ==', N'079bbee7-9f78-48ee-957c-29dd92b1e153', NULL, 0, 0, NULL, 1, 0, N'JoeD@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2fe0c77-552b-40b6-8e3c-0277ecf8cd04', N'ShempH@3stooges.com', 0, N'APA8LJxLHYRxaGwe0ZHkl1YHMXgw551UubQdHjfrw6mItqkWwIJZH1sVuZqi8jL9ww==', N'd9acdc21-4a0f-49f2-bc49-087a117f59a1', NULL, 0, 0, NULL, 1, 0, N'ShempH@3stooges.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe0dd274-c38b-4a47-a9ca-947a2a8ad71b', N'guest@amp.com', 0, N'AAXjxZvJrYa3p7b4JQo7eXD7q90BA7qmPBH3XccIMJbH61OukbDW5PmWFAV8EXHumQ==', N'd0e65f14-4ad3-44dd-9cc7-ad7fd97f301d', NULL, 0, 0, NULL, 1, 0, N'guest@amp.com')

");
        }
        
        public override void Down()
        {
        }
    }
}
