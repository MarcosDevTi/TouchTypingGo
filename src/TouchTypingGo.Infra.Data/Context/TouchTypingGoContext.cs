using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;
using TouchTypingGo.Infra.Data.Mappings;

namespace TouchTypingGo.Infra.Data.Context
{
    public class TouchTypingGoContext : DbContext
    {
        //public TouchTypingGoContext(DbContextOptions<TouchTypingGoContext> options) : base(options)
        //{
            
        //}
        public DbSet<Course> Courses { get; set; }
        public DbSet<LeconPresentation> LeconPresentations { get; set; }
        public DbSet<LeconResult> LeconResults { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CourseMapping());
            modelBuilder.AddConfiguration(new LeconPresentationMapping());
            modelBuilder.AddConfiguration(new LeconResultMapping());
            modelBuilder.AddConfiguration(new StudentMapping());
            modelBuilder.AddConfiguration(new TeacherMapping());


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));


            base.OnConfiguring(optionsBuilder);
        }
    }
}
