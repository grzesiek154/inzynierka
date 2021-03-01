namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableMod : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.rcpTransaction", "rcpTranType_IdTranType", "dbo.rcpTranType");
            DropForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers");
            DropIndex("dbo.rcpTransaction", new[] { "IdUser" });
            DropIndex("dbo.rcpTransaction", new[] { "rcpTranType_IdTranType" });
            AddForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers", "IdUser");
            DropTable("dbo.rcpTransaction");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.rcpTransaction",
                c => new
                    {
                        IdTrans = c.Long(nullable: false, identity: true),
                        DateAndTime = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdTransType = c.Int(nullable: false),
                        rcpTranType_IdTranType = c.Int(),
                    })
                .PrimaryKey(t => t.IdTrans);
            
            DropForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers");
            CreateIndex("dbo.rcpTransaction", "rcpTranType_IdTranType");
            CreateIndex("dbo.rcpTransaction", "IdUser");
            AddForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
            AddForeignKey("dbo.rcpTransaction", "rcpTranType_IdTranType", "dbo.rcpTranType", "IdTranType");
        }
    }
}
