namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PairsRestLp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.rcpPairsBRK", "Lp", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.rcpPairsOnB", "Lp", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.rcpPairsOnB", "Lp");
            DropColumn("dbo.rcpPairsBRK", "Lp");
        }
    }
}
