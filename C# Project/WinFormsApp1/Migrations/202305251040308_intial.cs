namespace WinFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(maxLength: 50),
                        Title = c.String(maxLength: 50),
                        Description = c.String(),
                        PathOfImage = c.String(),
                        Author = c.String(),
                        TotalCopies = c.Int(nullable: false),
                        AvailableCopies = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.ISBN, unique: true)
                .Index(t => t.Title, unique: true)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsReturned = c.Boolean(nullable: false),
                        Duration = c.Int(nullable: false),
                        BorrowedAt = c.DateTime(nullable: false),
                        Book_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Book_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(maxLength: 50),
                        SSN = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Email, unique: true)
                .Index(t => t.SSN, unique: true)
                .Index(t => t.Phone, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBooks", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.Books", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "Phone" });
            DropIndex("dbo.Users", new[] { "SSN" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.UserBooks", new[] { "User_ID" });
            DropIndex("dbo.UserBooks", new[] { "Book_ID" });
            DropIndex("dbo.Categories", new[] { "Name" });
            DropIndex("dbo.Books", new[] { "Category_Id" });
            DropIndex("dbo.Books", new[] { "Title" });
            DropIndex("dbo.Books", new[] { "ISBN" });
            DropTable("dbo.Users");
            DropTable("dbo.UserBooks");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.Admins");
        }
    }
}
