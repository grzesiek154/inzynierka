namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadTranTask : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.zadTaskProduction", "IdUser", "dbo.genUsers");
            DropIndex("dbo.zadTaskProduction", new[] { "IdUser" });
            DropPrimaryKey("dbo.zadTaskProduction");
            AddColumn("dbo.zadTaskProduction", "genUser_IdUser", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.zadTaskProduction", "IdUser");
            CreateIndex("dbo.zadTaskProduction", "genUser_IdUser");
            AddForeignKey("dbo.zadTaskProduction", "genUser_IdUser", "dbo.genUsers", "IdUser");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.zadTaskProduction", "genUser_IdUser", "dbo.genUsers");
            DropIndex("dbo.zadTaskProduction", new[] { "genUser_IdUser" });
            DropPrimaryKey("dbo.zadTaskProduction");
            DropColumn("dbo.zadTaskProduction", "genUser_IdUser");
            AddPrimaryKey("dbo.zadTaskProduction", new[] { "IdUser", "Start" });
            CreateIndex("dbo.zadTaskProduction", "IdUser");
            AddForeignKey("dbo.zadTaskProduction", "IdUser", "dbo.genUsers", "IdUser");
        }
    }
}
