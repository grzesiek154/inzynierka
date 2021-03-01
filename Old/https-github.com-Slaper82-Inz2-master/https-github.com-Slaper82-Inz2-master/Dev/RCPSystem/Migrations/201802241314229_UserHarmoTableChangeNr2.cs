namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserHarmoTableChangeNr2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.rcpUserHarmoList");
            AddPrimaryKey("dbo.rcpUserHarmoList", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.rcpUserHarmoList");
            AddPrimaryKey("dbo.rcpUserHarmoList", new[] { "Id", "IdUser", "IdHarmo", "ValidFrom", "ValidTo" });
        }
    }
}
