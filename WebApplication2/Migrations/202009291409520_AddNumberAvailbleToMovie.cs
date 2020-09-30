namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailbleToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "NumberAvailable", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateRented");
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
