namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.TeacherTransferes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FromSchool_ID = c.Int(),
                        ToSchool_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Schools", t => t.FromSchool_ID)
                .ForeignKey("dbo.Schools", t => t.ToSchool_ID)
                .Index(t => t.FromSchool_ID)
                .Index(t => t.ToSchool_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        NationalID = c.String(),
                        School_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Schools", t => t.School_ID)
                .Index(t => t.School_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "School_ID", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransferes", "ToSchool_ID", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransferes", "FromSchool_ID", "dbo.Schools");
            DropForeignKey("dbo.Schools", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "School_ID" });
            DropIndex("dbo.TeacherTransferes", new[] { "ToSchool_ID" });
            DropIndex("dbo.TeacherTransferes", new[] { "FromSchool_ID" });
            DropIndex("dbo.Schools", new[] { "Department_ID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.TeacherTransferes");
            DropTable("dbo.Schools");
            DropTable("dbo.Departments");
        }
    }
}
