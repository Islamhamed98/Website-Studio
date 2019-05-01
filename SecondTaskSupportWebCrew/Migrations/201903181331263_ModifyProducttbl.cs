namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyProducttbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Image");
        }
    }
}
