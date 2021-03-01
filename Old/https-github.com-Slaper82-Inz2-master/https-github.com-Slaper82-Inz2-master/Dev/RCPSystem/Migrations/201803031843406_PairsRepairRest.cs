namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PairsRepairRest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.rcpPairsBRK", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpPairsOnB", "IdUser", "dbo.genUsers");
            DropPrimaryKey("dbo.rcpPairsBRK");
            DropPrimaryKey("dbo.rcpPairsOnB");
            AddPrimaryKey("dbo.rcpPairsBRK", "Lp");
            AddPrimaryKey("dbo.rcpPairsOnB", "Lp");
            AddForeignKey("dbo.rcpPairsBRK", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
            AddForeignKey("dbo.rcpPairsOnB", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.rcpPairsOnB", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpPairsBRK", "IdUser", "dbo.genUsers");
            DropPrimaryKey("dbo.rcpPairsOnB");
            DropPrimaryKey("dbo.rcpPairsBRK");
            AddPrimaryKey("dbo.rcpPairsOnB", "IdUser");
            AddPrimaryKey("dbo.rcpPairsBRK", "IdUser");
            AddForeignKey("dbo.rcpPairsOnB", "IdUser", "dbo.genUsers", "IdUser");
            AddForeignKey("dbo.rcpPairsBRK", "IdUser", "dbo.genUsers", "IdUser");
        }
    }
}
