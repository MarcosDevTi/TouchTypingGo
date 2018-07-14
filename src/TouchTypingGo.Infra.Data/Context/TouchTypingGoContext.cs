using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Institution;
using TouchTypingGo.Infra.Data.Mappings;

namespace TouchTypingGo.Infra.Data.Context
{
    public class TouchTypingGoContext : DbContext
    {
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
            modelBuilder.ApplyConfiguration(new CourseMapping());
            modelBuilder.ApplyConfiguration(new LessonPresentationMapping());
            modelBuilder.ApplyConfiguration(new LessonResultMapping());
            modelBuilder.ApplyConfiguration(new StudentMapping());
            modelBuilder.ApplyConfiguration(new TeacherMapping());
            modelBuilder.ApplyConfiguration(new KeyboardMapping());
            modelBuilder.ApplyConfiguration(new CourseLessonPresentationMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new InstitutionMapping());

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
