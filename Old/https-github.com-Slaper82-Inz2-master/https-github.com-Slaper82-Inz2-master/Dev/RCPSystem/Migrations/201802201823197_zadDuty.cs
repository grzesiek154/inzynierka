namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadDuty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.zadDuties",
                c => new
                    {
                        IdDuty = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdDuty);
            
           
        }
        
        public override void Down()
        {
           
            DropTable("dbo.zadDuties");
        }
    }
}
