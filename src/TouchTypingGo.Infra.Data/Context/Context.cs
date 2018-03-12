using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Infra.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<LeconPresentation> LeconPresentations { get; set; }
        public DbSet<LeconResult> LeconResults { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentAPI

            #region Course

            modelBuilder.Entity<Course>()
                .Property(c => c.Code)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            modelBuilder.Entity<Course>()
                .Ignore(c => c.ValidationResult);

            modelBuilder.Entity<Course>()
                .Ignore(c => c.CascadeMode);

            modelBuilder.Entity<Course>()
                .ToTable("Courses");

            #endregion

            #region LeconPresentation

            modelBuilder.Entity<LeconPresentation>()
                .Property(l=>l.Category)
                .HasColumnType("varchar(20)")
                .IsRequired();

            #endregion

            #region LeconResult

            modelBuilder.Entity<LeconResult>()
                .Property(l => l.ErrorKey)
                .HasColumnType("varchar(2)")
                .IsRequired();

            modelBuilder.Entity<LeconResult>()
                .HasOne(lr => lr.LeconPresentation)
                .WithMany(la => la.LeconResults)
                .HasForeignKey(lr => lr.LeconPresentationId);

           
            #endregion

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
