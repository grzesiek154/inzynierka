namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserHarmoTableChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.rcpUserHarmoList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdHarmo = c.Int(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.IdUser, t.IdHarmo, t.ValidFrom, t.ValidTo })
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .ForeignKey("dbo.rcpHarmo", t => t.IdHarmo, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdHarmo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.rcpUserHarmoList", "IdHarmo", "dbo.rcpHarmo");
            DropForeignKey("dbo.rcpUserHarmoList", "IdUser", "dbo.genUsers");
            DropIndex("dbo.rcpUserHarmoList", new[] { "IdHarmo" });
            DropIndex("dbo.rcpUserHarmoList", new[] { "IdUser" });
            DropTable("dbo.rcpUserHarmoList");
        }
    }
}
