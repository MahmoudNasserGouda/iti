using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp1
{
    public class AppContext : DbContext
    {
        public AppContext() : base("Data Source=.;Initial Catalog=WinFormsApp;Integrated Security=true")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u => u.SSN).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Phone).IsUnique();
            modelBuilder.Entity<Book>().HasIndex(u => u.ISBN).IsUnique();
            modelBuilder.Entity<Book>().HasIndex(u => u.Title).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(u => u.Name).IsUnique();

        }
    }
}
