namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailbleToRentalClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "NumberAvailable", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "DateReturned");
            DropColumn("dbo.Rentals", "NumberAvailable");
        }
    }
}
