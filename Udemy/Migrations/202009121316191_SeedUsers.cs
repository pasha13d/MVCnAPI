namespace Udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9996440b-8ab5-406e-8e52-7f4d44be71cc', N'admin@gmail.com', 0, N'AKPRew5UraI8E52pWei5AxwxJ/m09Uj1/K3KIVzjuPwVLaQkDbLZCXHXdQEmeJtLQA==', N'32ba2e7b-6394-49f7-a693-8f1ae610b2c4', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cfbf5e70-5e0a-4eb1-a169-f111195b79cb', N'guest@gmail.com', 0, N'ADBBPRE9EgykC1l1WaO3xFVteeMUDr07AsV0tTz+hj2RqiudUouqQl/mYnRVofRbFQ==', N'88025fe3-0ab0-4798-8902-d05d34bb2760', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4227c56b-01b2-491f-a87d-10dc61680338', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9996440b-8ab5-406e-8e52-7f4d44be71cc', N'4227c56b-01b2-491f-a87d-10dc61680338')

");
        }
        
        public override void Down()
        {
        }
    }
}
