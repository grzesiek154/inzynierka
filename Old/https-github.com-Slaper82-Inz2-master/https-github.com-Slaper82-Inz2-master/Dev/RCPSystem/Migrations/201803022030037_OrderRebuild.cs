namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRebuild : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.zadOrderProduct");
            AlterColumn("dbo.zadOrderProduct", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.zadOrderProduct", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.zadOrderProduct");
            AlterColumn("dbo.zadOrderProduct", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.zadOrderProduct", new[] { "Id", "IdOrder", "IdProduct" });
        }
    }
}
