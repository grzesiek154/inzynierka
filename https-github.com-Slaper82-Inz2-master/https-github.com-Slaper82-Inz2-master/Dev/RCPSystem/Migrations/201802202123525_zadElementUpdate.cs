namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadElementUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.zadElement", "IdProduct", "dbo.zadProduct");
            DropIndex("dbo.zadElement", new[] { "IdProduct" });
            CreateTable(
                "dbo.zadProdElem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        IdElement = c.Int(nullable: false),
                        IdProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.zadProduct", t => t.IdProduct, cascadeDelete: true)
                .ForeignKey("dbo.zadElement", t => t.IdElement, cascadeDelete: true)
                .Index(t => t.IdElement)
                .Index(t => t.IdProduct);
            
            AddColumn("dbo.zadProduct", "Description", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.zadElement", "Description");
            DropColumn("dbo.zadElement", "IdProduct");
        }
        
        public override void Down()
        {
            AddColumn("dbo.zadElement", "IdProduct", c => c.Int(nullable: false));
            AddColumn("dbo.zadElement", "Description", c => c.String(nullable: false, maxLength: 200));
            DropForeignKey("dbo.zadProdElem", "IdElement", "dbo.zadElement");
            DropForeignKey("dbo.zadProdElem", "IdProduct", "dbo.zadProduct");
            DropIndex("dbo.zadProdElem", new[] { "IdProduct" });
            DropIndex("dbo.zadProdElem", new[] { "IdElement" });
            DropColumn("dbo.zadProduct", "Description");
            DropTable("dbo.zadProdElem");
            CreateIndex("dbo.zadElement", "IdProduct");
            AddForeignKey("dbo.zadElement", "IdProduct", "dbo.zadProduct", "IdProduct");
        }
    }
}
