namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        Studio = c.String(),
                        Style = c.String(),
                        Relise = c.DateTime(nullable: false),
                        Studios_Id = c.Int(),
                        Styles_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Studios", t => t.Studios_Id)
                .ForeignKey("dbo.Styles", t => t.Styles_Id)
                .Index(t => t.Studios_Id)
                .Index(t => t.Styles_Id);
            
            CreateTable(
                "dbo.Studios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudiosName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Styles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StylesName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Styles_Id", "dbo.Styles");
            DropForeignKey("dbo.Games", "Studios_Id", "dbo.Studios");
            DropIndex("dbo.Games", new[] { "Styles_Id" });
            DropIndex("dbo.Games", new[] { "Studios_Id" });
            DropTable("dbo.Styles");
            DropTable("dbo.Studios");
            DropTable("dbo.Games");
        }
    }
}
