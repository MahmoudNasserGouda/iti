using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Day4Demo.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Stud_Course> Stud_Course { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Stud_Course)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.Dept_Manager);
        }
    }
}
