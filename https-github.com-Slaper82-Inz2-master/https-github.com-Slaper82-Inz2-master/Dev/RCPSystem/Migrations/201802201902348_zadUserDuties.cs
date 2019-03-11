namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadUserDuties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.zadDutyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdType = c.Int(nullable: false),
                        zadDutys_IdDuty = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.zadDuties", t => t.zadDutys_IdDuty)
                .ForeignKey("dbo.zadTypes", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType)
                .Index(t => t.zadDutys_IdDuty);
            
            CreateTable(
                "dbo.zadUserDuties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        genUser_IdUser = c.Int(),
                        zadDuty_IdDuty = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.genUsers", t => t.genUser_IdUser)
                .ForeignKey("dbo.zadDuties", t => t.zadDuty_IdDuty)
                .Index(t => t.genUser_IdUser)
                .Index(t => t.zadDuty_IdDuty);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.zadUserDuties", "zadDuty_IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadUserDuties", "genUser_IdUser", "dbo.genUsers");
            DropForeignKey("dbo.zadDutyTypes", "IdType", "dbo.zadTypes");
            DropForeignKey("dbo.zadDutyTypes", "zadDutys_IdDuty", "dbo.zadDuties");
            DropIndex("dbo.zadUserDuties", new[] { "zadDuty_IdDuty" });
            DropIndex("dbo.zadUserDuties", new[] { "genUser_IdUser" });
            DropIndex("dbo.zadDutyTypes", new[] { "zadDutys_IdDuty" });
            DropIndex("dbo.zadDutyTypes", new[] { "IdType" });
            DropTable("dbo.zadUserDuties");
            DropTable("dbo.zadDutyTypes");
        }
    }
}
