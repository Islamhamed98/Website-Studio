namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditSessionModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sessions", "Photgrapher", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Sessions", "Location", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Sessions", "City", c => c.String());
            DropColumn("dbo.Sessions", "Name");
            DropColumn("dbo.Sessions", "ProductCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sessions", "ProductCategory", c => c.String());
            AddColumn("dbo.Sessions", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Sessions", "City");
            DropColumn("dbo.Sessions", "Location");
            DropColumn("dbo.Sessions", "Photgrapher");
        }
    }
}
