namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudioName : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Studios", "StudiosName", unique: true, name: "StudiosNameIndex");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Studios", "StudiosNameIndex");
        }
    }
}
