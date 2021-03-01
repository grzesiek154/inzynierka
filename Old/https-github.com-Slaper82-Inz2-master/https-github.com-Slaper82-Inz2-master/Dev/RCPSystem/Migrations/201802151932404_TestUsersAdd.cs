namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestUsersAdd : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jan','Kowalski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Antoni','Nowak',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Marian','Wisniewski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jerzy','Baran',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Stefan','Duren',1,1)");


            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode) values (1,'19880101','WWA','Czekoladowa','','Gdansk','01-100')");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode) values (2,'19870101','Radom','Czekoladowa','','Gdansk','01-100')");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode) values (3,'19860101','Kraków','Czekoladowa','','Gdansk','01-100')");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode) values (4,'19850101','Czestochowa','Czekoladowa','','Gdansk','01-100')");
            Sql("insert into genUserDet (IdUser,DateBirth,PlaceBirth,Adrress,Adrress2,City,ZipCode) values (5,'19840101','Zakopane','Czekoladowa','','Gdansk','01-100')");
        }
        
        public override void Down()
        {
        }
    }
}
