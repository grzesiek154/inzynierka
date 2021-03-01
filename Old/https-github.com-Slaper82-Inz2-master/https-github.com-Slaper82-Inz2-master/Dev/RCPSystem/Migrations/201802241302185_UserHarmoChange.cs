namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserHarmoChange : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.rcpUserHarmo");
            AddColumn("dbo.rcpUserHarmo", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.rcpUserHarmo", new[] { "Id", "IdUser", "IdHarmo", "ValidFrom", "ValidTo" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.rcpUserHarmo");
            DropColumn("dbo.rcpUserHarmo", "Id");
            AddPrimaryKey("dbo.rcpUserHarmo", new[] { "IdUser", "IdHarmo", "ValidFrom", "ValidTo" });
        }
    }
}
