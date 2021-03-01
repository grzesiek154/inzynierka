namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PairsIOIdentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.rcpPairsIO", "Lp", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.rcpPairsIO", "Lp");
        }
    }
}
