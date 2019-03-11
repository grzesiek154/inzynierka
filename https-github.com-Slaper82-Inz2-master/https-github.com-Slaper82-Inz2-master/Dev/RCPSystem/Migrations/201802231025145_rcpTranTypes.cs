namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rcpTranTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into rcpTranType (IdTranType,Name) values (1,'Start');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (2,'Stop');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (3,'Przerwa');");
            Sql("Insert into rcpTranType (IdTranType,Name) values (4,'Koniec przerwy');");
        }
        
        public override void Down()
        {
            Sql("Delete from rcpTranType");
        }
    }
}
