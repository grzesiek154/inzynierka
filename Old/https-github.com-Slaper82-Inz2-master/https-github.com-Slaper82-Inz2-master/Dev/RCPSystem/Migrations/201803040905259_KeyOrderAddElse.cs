namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KeyOrderAddElse : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.zadOrderProduct");
            AddColumn("dbo.zadOrderProduct", "IdKey", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.zadOrderProduct", "Quantity", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.zadOrderProduct", "IdKey");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.zadOrderProduct");
            AlterColumn("dbo.zadOrderProduct", "Quantity", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.zadOrderProduct", "IdKey");
            AddPrimaryKey("dbo.zadOrderProduct", "Quantity");
        }
    }
}
