namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.zadClient",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
            AddColumn("dbo.zadOrder", "IdClient", c => c.Int(nullable: false));
            CreateIndex("dbo.zadOrder", "IdClient");
            AddForeignKey("dbo.zadOrder", "IdClient", "dbo.zadClient", "IdClient", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.zadOrder", "IdClient", "dbo.zadClient");
            DropIndex("dbo.zadOrder", new[] { "IdClient" });
            DropColumn("dbo.zadOrder", "IdClient");
            DropTable("dbo.zadClient");
        }
    }
}
