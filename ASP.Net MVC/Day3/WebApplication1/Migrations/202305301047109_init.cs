namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CategoryID = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Supplier", t => t.SupplierID)
                .ForeignKey("dbo.Category", t => t.CategoryID)
                .Index(t => t.CategoryID)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupplierPhone",
                c => new
                    {
                        SupplierID = c.Int(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.SupplierID, t.Phone })
                .ForeignKey("dbo.Supplier", t => t.SupplierID)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Dnum = c.Int(nullable: false),
                        Dname = c.String(maxLength: 50, unicode: false),
                        MGRSSN = c.Int(),
                        MGRStartDate = c.DateTime(name: "MGRStart Date"),
                    })
                .PrimaryKey(t => t.Dnum)
                .ForeignKey("dbo.Employee", t => t.MGRSSN)
                .Index(t => t.MGRSSN);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        SSN = c.Int(nullable: false),
                        Fname = c.String(maxLength: 50, unicode: false),
                        Lname = c.String(maxLength: 50, unicode: false),
                        Bdate = c.DateTime(),
                        Address = c.String(maxLength: 50, unicode: false),
                        Sex = c.String(maxLength: 50, unicode: false),
                        Salary = c.Int(),
                        Superssn = c.Int(),
                        Dno = c.Int(),
                    })
                .PrimaryKey(t => t.SSN)
                .ForeignKey("dbo.Departments", t => t.Dno)
                .Index(t => t.Dno);
            
            CreateTable(
                "dbo.Dependent",
                c => new
                    {
                        ESSN = c.Int(nullable: false),
                        Dependent_name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sex = c.String(maxLength: 50, unicode: false),
                        Bdate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ESSN, t.Dependent_name })
                .ForeignKey("dbo.Employee", t => t.ESSN)
                .Index(t => t.ESSN);
            
            CreateTable(
                "dbo.Works_for",
                c => new
                    {
                        ESSn = c.Int(nullable: false),
                        Pno = c.Int(nullable: false),
                        Hours = c.Int(),
                    })
                .PrimaryKey(t => new { t.ESSn, t.Pno })
                .ForeignKey("dbo.Project", t => t.Pno)
                .ForeignKey("dbo.Employee", t => t.ESSn)
                .Index(t => t.ESSn)
                .Index(t => t.Pno);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Pnumber = c.Int(nullable: false),
                        Pname = c.String(maxLength: 50, unicode: false),
                        Plocation = c.String(maxLength: 50, unicode: false),
                        City = c.String(maxLength: 50, unicode: false),
                        Dnum = c.Int(),
                    })
                .PrimaryKey(t => t.Pnumber)
                .ForeignKey("dbo.Departments", t => t.Dnum)
                .Index(t => t.Dnum);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Dno", "dbo.Departments");
            DropForeignKey("dbo.Works_for", "ESSn", "dbo.Employee");
            DropForeignKey("dbo.Works_for", "Pno", "dbo.Project");
            DropForeignKey("dbo.Project", "Dnum", "dbo.Departments");
            DropForeignKey("dbo.Dependent", "ESSN", "dbo.Employee");
            DropForeignKey("dbo.Departments", "MGRSSN", "dbo.Employee");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.SupplierPhone", "SupplierID", "dbo.Supplier");
            DropForeignKey("dbo.Product", "SupplierID", "dbo.Supplier");
            DropIndex("dbo.Project", new[] { "Dnum" });
            DropIndex("dbo.Works_for", new[] { "Pno" });
            DropIndex("dbo.Works_for", new[] { "ESSn" });
            DropIndex("dbo.Dependent", new[] { "ESSN" });
            DropIndex("dbo.Employee", new[] { "Dno" });
            DropIndex("dbo.Departments", new[] { "MGRSSN" });
            DropIndex("dbo.SupplierPhone", new[] { "SupplierID" });
            DropIndex("dbo.Product", new[] { "SupplierID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropTable("dbo.Project");
            DropTable("dbo.Works_for");
            DropTable("dbo.Dependent");
            DropTable("dbo.Employee");
            DropTable("dbo.Departments");
            DropTable("dbo.SupplierPhone");
            DropTable("dbo.Supplier");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
