namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskProdNullEnable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.zadTaskProduction", "Start", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.zadTaskProduction", "Start", c => c.DateTime(nullable: false));
        }
    }
}
