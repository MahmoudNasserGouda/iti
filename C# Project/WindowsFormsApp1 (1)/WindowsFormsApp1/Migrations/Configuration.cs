namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinFormsApp1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormsApp1.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WinFormsApp1.AppContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WinFormsApp1.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Seed data for Admin
            var admin1 = new Admin { ID = 1, UserName = "admin", Password = "123456" };
            var admin2 = new Admin { ID = 2, UserName = "a", Password = "a" };
            context.Admins.AddOrUpdate(a => a.ID, admin1, admin2);

            // Seed data for Category
            var fictionCategory = new Category { Id = 1, Name = "Fiction" };
            var nonFictionCategory = new Category { Id = 2, Name = "Non-Fiction" };
            var childrensCategory = new Category { Id = 3, Name = "Children's Books" };
            context.Categories.AddOrUpdate(c => c.Id, fictionCategory, nonFictionCategory, childrensCategory);

            // Seed data for Book
            var book1 = new Book
            {
                ID = 1,
                ISBN = "9780143127550",
                Title = "The Goldfinch",
                Description = "A young boy in New York City, Theo Decker, miraculously survives an explosion that takes the life of his mother.",
                PathOfImage = "goldfinch.jpg",
                Author = "Donna Tartt",
                Category = fictionCategory,
                TotalCopies = 5,
                AvailableCopies = 4
            };
            var book2 = new Book
            {
                ID = 2,
                ISBN = "9780060800635",
                Title = "The Immortal Life of Henrietta Lacks",
                Description = "This book tells the story of Henrietta Lacks, an African American woman whose cancer cells were taken without her knowledge in 1951 and have been used for scientific research ever since.",
                PathOfImage = "henrietta-lacks.jpg",
                Author = "Rebecca Skloot",
                Category = nonFictionCategory,
                TotalCopies = 3,
                AvailableCopies = 2
            };
            var book3 = new Book
            {
                ID = 3,
                ISBN = "9780142410363",
                Title = "The Graveyard Book",
                Description = "After the grisly murder of his entire family, a toddler wanders into a graveyard where the ghosts and other supernatural residents agree to raise him as one of their own.",
                PathOfImage = "graveyard-book.jpg",
                Author = "Neil Gaiman",
                Category = childrensCategory,
                TotalCopies = 2,
                AvailableCopies = 2
            };
            context.Books.AddOrUpdate(b => b.ID, book1, book2, book3);

            // Seed data for User
            var user1 = new User { ID = 1, Name = "John Doe", Email = "johndoe@example.com", SSN = "123-45-6789", Phone = "555-123-4567" };
            var user2 = new User { ID = 2, Name = "Jane Smith", Email = "janesmith@example.com", SSN = "987-65-4321", Phone = "555-987-6543" };
            context.Users.AddOrUpdate(u => u.ID, user1, user2);

            // Seed data for UserBook
            var userBook1 = new UserBook { Id = 1, User = user1, Book = book1, IsReturned = false, Duration = 14, BorrowedAt = DateTime.Now.AddDays(-7) };
            var userBook2 = new UserBook { Id = 2, User = user2, Book = book2, IsReturned = false, Duration = 21, BorrowedAt = DateTime.Now.AddDays(-14) };
            context.UserBooks.AddOrUpdate(ub => ub.Id, userBook1, userBook2);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
