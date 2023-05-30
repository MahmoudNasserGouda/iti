using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=connection_string")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Dependent> Dependent { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierPhone> SupplierPhone { get; set; }
        public virtual DbSet<Works_for> Works_for { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departments>()
                .Property(e => e.Dname)
                .IsUnicode(false);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Employee1)
                .WithOptional(e => e.Departments1)
                .HasForeignKey(e => e.Dno);

            modelBuilder.Entity<Dependent>()
                .Property(e => e.Dependent_name)
                .IsUnicode(false);

            modelBuilder.Entity<Dependent>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.MGRSSN);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Dependent)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ESSN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Works_for)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ESSn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Pname)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Plocation)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Works_for)
                .WithRequired(e => e.Project)
                .HasForeignKey(e => e.Pno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.SupplierPhone)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierPhone>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<WebApplication1.ViewModel.ProductViewModel> ProductViewModels { get; set; }
    }
}
