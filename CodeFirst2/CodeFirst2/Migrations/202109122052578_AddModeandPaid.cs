namespace CodeFirst2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModeandPaid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "Paid", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "Mode", c => c.String());
            AddColumn("dbo.Games", "Modes_Id", c => c.Int());
            CreateIndex("dbo.Games", "Modes_Id");
            AddForeignKey("dbo.Games", "Modes_Id", "dbo.Modes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Modes_Id", "dbo.Modes");
            DropIndex("dbo.Games", new[] { "Modes_Id" });
            DropColumn("dbo.Games", "Modes_Id");
            DropColumn("dbo.Games", "Mode");
            DropColumn("dbo.Games", "Paid");
            DropTable("dbo.Modes");
        }
    }
}
