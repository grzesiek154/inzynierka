namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadUserDuties_Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.zadDutyTypes", "zadDutys_IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadUserDuties", "zadDuty_IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadUserDuties", "genUser_IdUser", "dbo.genUsers");
            DropIndex("dbo.zadDutyTypes", new[] { "zadDutys_IdDuty" });
            DropIndex("dbo.zadUserDuties", new[] { "genUser_IdUser" });
            DropIndex("dbo.zadUserDuties", new[] { "zadDuty_IdDuty" });
            RenameColumn(table: "dbo.zadDutyTypes", name: "zadDutys_IdDuty", newName: "IdDuty");
            RenameColumn(table: "dbo.zadUserDuties", name: "zadDuty_IdDuty", newName: "IdDuty");
            RenameColumn(table: "dbo.zadUserDuties", name: "genUser_IdUser", newName: "IdUser");
            AlterColumn("dbo.zadDutyTypes", "IdDuty", c => c.Int(nullable: false));
            AlterColumn("dbo.zadUserDuties", "IdUser", c => c.Int(nullable: false));
            AlterColumn("dbo.zadUserDuties", "IdDuty", c => c.Int(nullable: false));
            CreateIndex("dbo.zadDutyTypes", "IdDuty");
            CreateIndex("dbo.zadUserDuties", "IdUser");
            CreateIndex("dbo.zadUserDuties", "IdDuty");
            AddForeignKey("dbo.zadDutyTypes", "IdDuty", "dbo.zadDuties", "IdDuty", cascadeDelete: true);
            AddForeignKey("dbo.zadUserDuties", "IdDuty", "dbo.zadDuties", "IdDuty", cascadeDelete: true);
            AddForeignKey("dbo.zadUserDuties", "IdUser", "dbo.genUsers", "IdUser", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.zadUserDuties", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.zadUserDuties", "IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadDutyTypes", "IdDuty", "dbo.zadDuties");
            DropIndex("dbo.zadUserDuties", new[] { "IdDuty" });
            DropIndex("dbo.zadUserDuties", new[] { "IdUser" });
            DropIndex("dbo.zadDutyTypes", new[] { "IdDuty" });
            AlterColumn("dbo.zadUserDuties", "IdDuty", c => c.Int());
            AlterColumn("dbo.zadUserDuties", "IdUser", c => c.Int());
            AlterColumn("dbo.zadDutyTypes", "IdDuty", c => c.Int());
            RenameColumn(table: "dbo.zadUserDuties", name: "IdUser", newName: "genUser_IdUser");
            RenameColumn(table: "dbo.zadUserDuties", name: "IdDuty", newName: "zadDuty_IdDuty");
            RenameColumn(table: "dbo.zadDutyTypes", name: "IdDuty", newName: "zadDutys_IdDuty");
            CreateIndex("dbo.zadUserDuties", "zadDuty_IdDuty");
            CreateIndex("dbo.zadUserDuties", "genUser_IdUser");
            CreateIndex("dbo.zadDutyTypes", "zadDutys_IdDuty");
            AddForeignKey("dbo.zadUserDuties", "genUser_IdUser", "dbo.genUsers", "IdUser");
            AddForeignKey("dbo.zadUserDuties", "zadDuty_IdDuty", "dbo.zadDuties", "IdDuty");
            AddForeignKey("dbo.zadDutyTypes", "zadDutys_IdDuty", "dbo.zadDuties", "IdDuty");
        }
    }
}
