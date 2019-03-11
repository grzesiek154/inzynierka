namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.genUserDet", "IsWoman", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
        }
    }
}
