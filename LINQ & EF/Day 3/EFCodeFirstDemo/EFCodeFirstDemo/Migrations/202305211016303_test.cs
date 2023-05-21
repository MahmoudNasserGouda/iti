namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dept",
                c => new
                    {
                        DeptID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeptID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Int(nullable: false),
                        Address_City = c.String(),
                        Address_Street = c.String(),
                        Address_ZipCode = c.Int(nullable: false),
                        Address_Location_Ay7aga = c.String(),
                        Department_DeptID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dept", t => t.Department_DeptID)
                .Index(t => t.Department_DeptID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProjectEmployees",
                c => new
                    {
                        Project_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_ID, t.Employee_ID })
                .ForeignKey("dbo.Projects", t => t.Project_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Project_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectEmployees", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.ProjectEmployees", "Project_ID", "dbo.Projects");
            DropForeignKey("dbo.Employees", "Department_DeptID", "dbo.Dept");
            DropIndex("dbo.ProjectEmployees", new[] { "Employee_ID" });
            DropIndex("dbo.ProjectEmployees", new[] { "Project_ID" });
            DropIndex("dbo.Employees", new[] { "Department_DeptID" });
            DropTable("dbo.ProjectEmployees");
            DropTable("dbo.Projects");
            DropTable("dbo.Employees");
            DropTable("dbo.Dept");
        }
    }
}
