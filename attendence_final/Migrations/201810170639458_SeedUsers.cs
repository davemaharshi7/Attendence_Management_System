namespace attendence_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e54853d-f653-4ace-945a-5e838f9258d9', N'admin1@ams.com', 0, N'AL77qtAHjG/zY0z4/88RA0LeKORAUxK3pNzsYL7zuOc2H7ICh70fNJHU7h3XHHs0tA==', N'85e36fe1-5b74-4be2-abd6-2f1b24a1ac6b', NULL, 0, 0, NULL, 1, 0, N'admin1@ams.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'83d5d97f-7ea7-42dd-9646-c852379d0636', N'faculty1@ams.com', 0, N'AJ1KNBlVKYOMdP3tC3k670Jl0rQl09Z3hu4zi9qgpGMNWLELIczCwe3TrLpAgOGVRA==', N'1553e30f-733f-4114-95fd-2a2e56be54fb', NULL, 0, 0, NULL, 1, 0, N'faculty1@ams.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'87eb87b9-f3b9-45c9-9af5-a3a76e82fed7', N'stud1@ams.com', 0, N'AAoyMYi1CNObyiRVpWlpneCGqP1L5b0YGT+IGQlBxgzg5FvjmWFKBw/3KRw57qkCqg==', N'95c88610-85b1-4d73-9195-5a7d19a8f874', NULL, 0, 0, NULL, 1, 0, N'stud1@ams.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96fa45a9-edae-4b19-8d4c-013b37081655', N'student1@ams.com', 0, N'AC8oc/tyLRHoKDumR3ylYCdzntPQFho2NgKPLzb22pq8WeEgdWyN8nCDytyhrxXUgg==', N'fe09dd61-d167-4473-95b3-6f8bb991faa5', NULL, 0, 0, NULL, 1, 0, N'student1@ams.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fba29615-bf2b-44aa-afd9-6dd1d864983d', N'Admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'692d77e5-e573-40e9-8cc3-ab64c2695a00', N'Faculty')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'487b6b92-76a2-41c1-ac47-1cedce4bab60', N'Student')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83d5d97f-7ea7-42dd-9646-c852379d0636', N'692d77e5-e573-40e9-8cc3-ab64c2695a00')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1e54853d-f653-4ace-945a-5e838f9258d9', N'fba29615-bf2b-44aa-afd9-6dd1d864983d')


");
        }
        
        public override void Down()
        {
        }
    }
}
