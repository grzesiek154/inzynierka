namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StructureAndLogins : DbMigration
    {
        public override void Up()
        {
            //loginy
            Sql("insert into genLogin  values (1,'a','a',0)");
            Sql("insert into genLogin  values (2,'b','b',0)");
            Sql("insert into genLogin  values (3,'c','c',0)");
            Sql("insert into genLogin  values (4,'d','d',0)");

            //Struktura
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Meblex',null)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Handlowy',1)");
            Sql("insert into genOrgUnit (Name,IdHigherOrgUnit) values ('Kadry',1)");
        }
        
        public override void Down()
        {
        }
    }
}
