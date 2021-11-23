using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TimeTable
{
    public partial class TimeTableContext : DbContext
    {
        public TimeTableContext()
        {
        }

        public TimeTableContext(DbContextOptions<TimeTableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectHour> ProjectHours { get; set; }
        public virtual DbSet<ProjectMonth> ProjectMonths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TimeTable;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeEgn).IsUnicode(false);

                entity.Property(e => e.EmployeeLastname).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.EmployeePosition).IsUnicode(false);

                entity.Property(e => e.EmployeeSurname).IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectDescription).IsUnicode(false);

                entity.Property(e => e.ProjectName).IsUnicode(false);

                entity.Property(e => e.ProjectStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProjectHour>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.EmployeeId, e.ProjectTaskdate });

                entity.Property(e => e.ProjectTask).IsUnicode(false);
            });

            modelBuilder.Entity<ProjectMonth>(entity =>
            {
                entity.Property(e => e.ProjectMonthStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMonths)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROJECT__REFERENCE_PROJECT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
