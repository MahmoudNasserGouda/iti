namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeacherTransferes", "Teacher_ID", c => c.Int());
            CreateIndex("dbo.TeacherTransferes", "Teacher_ID");
            AddForeignKey("dbo.TeacherTransferes", "Teacher_ID", "dbo.Teachers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherTransferes", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.TeacherTransferes", new[] { "Teacher_ID" });
            DropColumn("dbo.TeacherTransferes", "Teacher_ID");
        }
    }
}
