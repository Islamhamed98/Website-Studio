namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnColumnToSessiontbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Photgraphy", c => c.String(maxLength: 255));
            AlterColumn("dbo.Products", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.String(maxLength: 255));
            DropColumn("dbo.Products", "Photgraphy");
        }
    }
}
