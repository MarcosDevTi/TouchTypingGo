using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;
using TouchTypingGo.Infra.Data.Mappings;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Infra.Data.Context
{
    public class TouchTypingGoContext : DbContext
    {
        //public TouchTypingGoContext(DbContextOptions<TouchTypingGoContext> options) : base(options)
        //{
            
        //}
        public DbSet<Course> Courses { get; set; }
        public DbSet<LessonPresentation> LessonPresentations { get; set; }
        public DbSet<LessonResult> LessonResults { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<CourseLessonPresentation> CourseLessonPresentations { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CourseMapping());
            modelBuilder.AddConfiguration(new LessonPresentationMapping());
            modelBuilder.AddConfiguration(new LessonResultMapping());
            modelBuilder.AddConfiguration(new StudentMapping());
            modelBuilder.AddConfiguration(new TeacherMapping());
            modelBuilder.AddConfiguration(new KeyboardMapping());
            modelBuilder.AddConfiguration(new CourseLessonPresentationMapping());
            modelBuilder.AddConfiguration(new AddressMapping());
            modelBuilder.AddConfiguration(new InstitutionMapping());

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
