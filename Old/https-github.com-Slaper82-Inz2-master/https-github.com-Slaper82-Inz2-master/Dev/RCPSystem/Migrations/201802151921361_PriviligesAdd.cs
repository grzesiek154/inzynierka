namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriviligesAdd : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genRoles (IdRole,Name,Active) values (1,'Administrator',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (2,'Boss',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (3,'Supervisor',1)");
            Sql("insert into genRoles(IdRole,Name,Active) values (4,'HumanResorces',1)");
            Sql("insert into genRoles (IdRole,Name,Active) values (5,'Worker',1)");
        }
        
        public override void Down()
        {
        }
    }
}
