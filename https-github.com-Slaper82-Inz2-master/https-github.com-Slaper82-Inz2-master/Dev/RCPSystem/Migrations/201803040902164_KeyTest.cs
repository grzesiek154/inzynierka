namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KeyTest : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.zadOrderProduct");
            AlterColumn("dbo.zadOrderProduct", "Quantity", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.zadOrderProduct", "Quantity");
            DropColumn("dbo.zadOrderProduct", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.zadOrderProduct", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.zadOrderProduct");
            AlterColumn("dbo.zadOrderProduct", "Quantity", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.zadOrderProduct", "Id");
        }
    }
}
