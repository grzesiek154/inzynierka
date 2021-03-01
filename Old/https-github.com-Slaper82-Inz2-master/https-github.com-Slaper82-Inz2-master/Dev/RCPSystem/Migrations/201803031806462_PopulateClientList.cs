namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClientList : DbMigration
    {
        public override void Up()
        {
            Sql("insert into zadClient values ('Salon Meblowy Stefan',1);");
            Sql("insert into zadClient values ('Jurek Kowalski',1);");
            Sql("insert into zadClient values ('Agata Meble',1);");
            Sql("insert into zadClient values ('IKEA',1);");
            Sql("insert into zadClient values ('Nowy Salon Mody',1);");
        }
        
        public override void Down()
        {
        }
    }
}
