namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PairsTest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.rcpPairsIO", "IdUser", "dbo.genUsers");
            DropPrimaryKey("dbo.rcpPairsIO");
            AddPrimaryKey("dbo.rcpPairsIO", "Lp");
            AddForeignKey("dbo.rcpPairsIO", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.rcpPairsIO", "IdUser", "dbo.genUsers");
            DropPrimaryKey("dbo.rcpPairsIO");
            AddPrimaryKey("dbo.rcpPairsIO", "IdUser");
            AddForeignKey("dbo.rcpPairsIO", "IdUser", "dbo.genUsers", "IdUser");
        }
    }
}
