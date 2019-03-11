namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.rcpTransaction");
            AlterColumn("dbo.rcpTransaction", "IdTrans", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.rcpTransaction", new[] { "IdTrans", "DateAndTime", "IdUser", "IdTransType" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.rcpTransaction");
            AlterColumn("dbo.rcpTransaction", "IdTrans", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.rcpTransaction", new[] { "IdTrans", "DateAndTime", "IdUser", "IdTransType" });
        }
    }
}
