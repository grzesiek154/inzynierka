namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionMod : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.rcpTransaction", "IdTransType", "dbo.rcpTranType");
            DropIndex("dbo.rcpTransaction", new[] { "IdTransType" });
            DropIndex("dbo.rcpTransactionAll", new[] { "rcpTranType_IdTranType" });
            DropColumn("dbo.rcpTransactionAll", "IdTransType");
            RenameColumn(table: "dbo.rcpTransactionAll", name: "rcpTranType_IdTranType", newName: "IdTransType");
            AddColumn("dbo.rcpTransaction", "rcpTranType_IdTranType", c => c.Int());
            AlterColumn("dbo.rcpTransactionAll", "IdTransType", c => c.Int(nullable: false));
            CreateIndex("dbo.rcpTransaction", "rcpTranType_IdTranType");
            CreateIndex("dbo.rcpTransactionAll", "IdTransType");
            AddForeignKey("dbo.rcpTransaction", "rcpTranType_IdTranType", "dbo.rcpTranType", "IdTranType");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.rcpTransaction", "rcpTranType_IdTranType", "dbo.rcpTranType");
            DropIndex("dbo.rcpTransactionAll", new[] { "IdTransType" });
            DropIndex("dbo.rcpTransaction", new[] { "rcpTranType_IdTranType" });
            AlterColumn("dbo.rcpTransactionAll", "IdTransType", c => c.Int());
            DropColumn("dbo.rcpTransaction", "rcpTranType_IdTranType");
            RenameColumn(table: "dbo.rcpTransactionAll", name: "IdTransType", newName: "rcpTranType_IdTranType");
            AddColumn("dbo.rcpTransactionAll", "IdTransType", c => c.Int(nullable: false));
            CreateIndex("dbo.rcpTransactionAll", "rcpTranType_IdTranType");
            CreateIndex("dbo.rcpTransaction", "IdTransType");
            AddForeignKey("dbo.rcpTransaction", "IdTransType", "dbo.rcpTranType", "IdTranType");
        }
    }
}
