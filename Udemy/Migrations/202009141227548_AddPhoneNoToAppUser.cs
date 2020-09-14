namespace Udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNoToAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNo", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhoneNo");
        }
    }
}
