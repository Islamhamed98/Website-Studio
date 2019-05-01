namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminRole", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "Password");
            DropColumn("dbo.Admins", "AdminRole");
        }
    }
}
