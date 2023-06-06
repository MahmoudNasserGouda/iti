using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVC6EFDemo.Models
{
    public partial class ITIContext : DbContext
    {
        public ITIContext()
        {
        }

        public ITIContext(DbContextOptions<ITIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Emp2> Emp2s { get; set; }
        public virtual DbSet<ExtQuestion> ExtQuestions { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<StudCourse> StudCourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student1> Students1 { get; set; }
        public virtual DbSet<TestView1> TestView1s { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CrsId);

                entity.ToTable("Course");

                entity.Property(e => e.CrsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Crs_Id");

                entity.Property(e => e.CrsDuration).HasColumnName("Crs_Duration");

                entity.Property(e => e.CrsName)
                    .HasMaxLength(50)
                    .HasColumnName("Crs_Name");

                entity.Property(e => e.InsId).HasColumnName("Ins_Id");

                entity.Property(e => e.TopId).HasColumnName("Top_Id");

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InsId)
                    .HasConstraintName("FK_Course_Instructor");

                entity.HasOne(d => d.Top)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TopId)
                    .HasConstraintName("FK_Course_Topic");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data");

                entity.HasIndex(e => e.Id, "DataIndex")
                    .IsClustered();

                entity.HasIndex(e => e.Id, "UQ__data__3214EC268E2B0133")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("Department");

                entity.Property(e => e.DeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("Dept_Id");

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(100)
                    .HasColumnName("Dept_Desc");

                entity.Property(e => e.DeptLocation)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Location");

                entity.Property(e => e.DeptManager).HasColumnName("Dept_Manager");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Name");

                entity.Property(e => e.Hiredate).HasColumnType("date");

                entity.HasOne(d => d.DeptManagerNavigation)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.DeptManager)
                    .HasConstraintName("FK_Department_Instructor");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Emp2>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__emp2__AF2DBA79B50D70AF");

                entity.ToTable("emp2", "sd");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpName).HasMaxLength(50);
            });

            modelBuilder.Entity<ExtQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extQuestions");

                entity.Property(e => e.AnswerKeyWords).HasColumnType("xml");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuesText).IsUnicode(false);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("Instructor", "sd");

                entity.Property(e => e.InsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ins_Id");

                entity.Property(e => e.DeptId).HasColumnName("Dept_Id");

                entity.Property(e => e.InsDegree)
                    .HasMaxLength(50)
                    .HasColumnName("Ins_Degree");

                entity.Property(e => e.InsName)
                    .HasMaxLength(50)
                    .HasColumnName("Ins_Name");
            });

            modelBuilder.Entity<StudCourse>(entity =>
            {
                entity.HasKey(e => new { e.CrsId, e.StId });

                entity.ToTable("Stud_Course");

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stud_Course_Course");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.StId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stud_Course_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Age).HasComputedColumnSql("([dbo].[CalcAge]([BirthDate]))", false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("Student", "newschema");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("St_Id");

                entity.Property(e => e.DeptId).HasColumnName("Dept_Id");

                entity.Property(e => e.StAddress)
                    .HasMaxLength(100)
                    .HasColumnName("St_Address");

                entity.Property(e => e.StAge).HasColumnName("St_Age");

                entity.Property(e => e.StFname)
                    .HasMaxLength(50)
                    .HasColumnName("St_Fname");

                entity.Property(e => e.StLname)
                    .HasMaxLength(10)
                    .HasColumnName("St_Lname")
                    .IsFixedLength(true);

                entity.Property(e => e.StSuper).HasColumnName("St_super");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Student1s)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Student_Department");

                entity.HasOne(d => d.StSuperNavigation)
                    .WithMany(p => p.InverseStSuperNavigation)
                    .HasForeignKey(d => d.StSuper)
                    .HasConstraintName("FK_Student_Student");
            });

            modelBuilder.Entity<TestView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TestView1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(e => e.TopId);

                entity.ToTable("Topic");

                entity.Property(e => e.TopId)
                    .ValueGeneratedNever()
                    .HasColumnName("Top_Id");

                entity.Property(e => e.TopName)
                    .HasMaxLength(50)
                    .HasColumnName("Top_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
