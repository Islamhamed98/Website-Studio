namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editname : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Price = c.String(maxLength: 255),
                        Description = c.String(maxLength: 500),
                        ProductCategory = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Price = c.String(maxLength: 255),
                        Description = c.String(maxLength: 500),
                        ProductCategory = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Sessions");
        }
    }
}
