using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected ApplicationContext()
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=mvcday8;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(i => i.ID);

            modelBuilder.Entity<Instructor>().HasKey(i => i.ID);
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, Name = "Ahmed" },
                new Instructor { ID = 2, Name = "Mahmoud" },
                new Instructor { ID = 3, Name = "Mohamed" },
                new Instructor { ID = 4, Name = "Mostafa" }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
