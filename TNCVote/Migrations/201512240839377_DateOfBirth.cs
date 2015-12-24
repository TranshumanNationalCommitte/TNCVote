namespace TNCVote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Birthday", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Birthday");
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
