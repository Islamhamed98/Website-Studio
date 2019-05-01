namespace SecondTaskSupportWebCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDatatoEntities : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Admins (Name, Gender , AdminRole , Password ) VALUES ('admin' , 'male',1,123456) ");
            Sql("INSERT INTO Admins (Name, Gender , AdminRole , Password ) VALUES ('elsam' , 'male',1,123456) ");
            Sql("INSERT INTO Admins (Name, Gender , AdminRole , Password ) VALUES ('bono' , 'male',1,123456) ");
            Sql("INSERT INTO Admins (Name, Gender , AdminRole , Password ) VALUES ('hager' , 'male',1,123456) ");

        }
        
        public override void Down()
        {
        }
    }
}
