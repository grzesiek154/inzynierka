namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactAllAdd : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.rcpTransaction");
            CreateTable(
                "dbo.rcpTransactionAll",
                c => new
                    {
                        IdTrans = c.Long(nullable: false, identity: true),
                        DateAndTime = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdTransType = c.Int(nullable: false),
                        rcpTranType_IdTranType = c.Int(),
                    })
                .PrimaryKey(t => t.IdTrans)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .ForeignKey("dbo.rcpTranType", t => t.rcpTranType_IdTranType)
                .Index(t => t.IdUser)
                .Index(t => t.rcpTranType_IdTranType);
            
            AddPrimaryKey("dbo.rcpTransaction", "IdTrans");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.rcpTransactionAll", "rcpTranType_IdTranType", "dbo.rcpTranType");
            DropForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers");
            DropIndex("dbo.rcpTransactionAll", new[] { "rcpTranType_IdTranType" });
            DropIndex("dbo.rcpTransactionAll", new[] { "IdUser" });
            DropPrimaryKey("dbo.rcpTransaction");
            DropTable("dbo.rcpTransactionAll");
            AddPrimaryKey("dbo.rcpTransaction", new[] { "IdTrans", "DateAndTime", "IdUser", "IdTransType" });
        }
    }
}
