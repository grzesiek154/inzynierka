namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderFieldAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.zadOrderProduct", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.zadOrderProduct", "Quantity");
        }
    }
}
