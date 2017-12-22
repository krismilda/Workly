namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
     /*       Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Surname], [Phone]) VALUES (N'c8738ee0-ee19-4de8-81a8-01cd9c69e14c', N'emloyee@abc.com', 0, N'AOLPP7zVCqGlix89kt6TY6ltM+ljb58uFJKgiSaEj21enBGgZd/st+4+ICcycNPKSw==', N'3a7b53b9-899d-4491-ad65-2130b9f2fe4c', NULL, 0, 0, NULL, 1, 0, N'emloyee@abc.com', N'Petras', N'Petraitis', N'862222222')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Surname], [Phone]) VALUES (N'c8f00fb6-7a22-4994-bf08-7ab772f07184', N'employer@abcc.com', 0, N'AMCaVFbZXgpxM4dCsSudXDDTYwuMSaoTrOizf90qM2Y+j1BumyZQeKCtWicPHlUsow==', N'82128c86-2999-471d-ae84-13138c4cb0be', NULL, 0, 0, NULL, 1, 0, N'employer@abcc.com', N'Ona', N'Onute', N'863333333')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9e61f3f6-16df-42cb-8571-40e9a6f39379', N'Employee')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'77bc6620-6008-4045-ae07-27272e5be5ed', N'Employer')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8f00fb6-7a22-4994-bf08-7ab772f07184', N'77bc6620-6008-4045-ae07-27272e5be5ed')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8738ee0-ee19-4de8-81a8-01cd9c69e14c', N'9e61f3f6-16df-42cb-8571-40e9a6f39379')

");*/
        }
        
        public override void Down()
        {
        }
    }
}
