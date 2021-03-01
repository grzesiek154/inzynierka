namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskProdUpdates : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.zadTaskProduction");
            AddColumn("dbo.zadTaskProduction", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.zadTaskProduction", "Id");
            CreateIndex("dbo.zadTaskProduction", "IdUser");
            AddForeignKey("dbo.zadTaskProduction", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
            DropColumn("dbo.zadTaskProduction", "genUser_IdUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.zadTaskProduction", "genUser_IdUser", c => c.Int());
            DropForeignKey("dbo.zadTaskProduction", "IdUser", "dbo.genUsers");
            DropIndex("dbo.zadTaskProduction", new[] { "IdUser" });
            DropPrimaryKey("dbo.zadTaskProduction");
            DropColumn("dbo.zadTaskProduction", "Id");
            AddPrimaryKey("dbo.zadTaskProduction", "IdUser");
        }
    }
}
