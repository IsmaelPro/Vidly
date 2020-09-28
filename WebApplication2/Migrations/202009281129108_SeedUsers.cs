namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20f7598a-4548-4f3f-85fa-4985fa82fd3b', N'ismael496@yahoo.com.br', 0, N'AFrOweOyF3AfD2/YFxJO13p+9yF480zWsYnfnbSOa06P+5zbYICHQXVctawWVx8vqA==', N'11171403-c671-47a2-b2bd-3a5b9f27b263', NULL, 0, 0, NULL, 1, 0, N'ismael496@yahoo.com.br')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96149249-d7bf-44f0-894a-de7013350ed8', N'admin@bidly.com', 0, N'AONUMA1Dg+KvJadj/GeTODiqZbOXruhirS/wsJi12H61UQT0wvZcp11ZX15aYY0vew==', N'2e887964-524d-4b58-ab88-4601908acaa9', NULL, 0, 0, NULL, 1, 0, N'admin@bidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ef92409e-b985-45f0-9082-276904ee1d31', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96149249-d7bf-44f0-894a-de7013350ed8', N'ef92409e-b985-45f0-9082-276904ee1d31')

");
        }

        public override void Down()
        {
        }
    }
}
