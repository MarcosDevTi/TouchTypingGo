using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TouchTypingGo.Data.Test.Extentions;
using TouchTypingGo.Data.Test.Mappings;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Data.Test.Context
{
    public class TouchTypingGoContextTest : DbContext
    {
        public TouchTypingGoContextTest(DbContextOptions<TouchTypingGoContextTest> options) : base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<lessonPresentation> lessonPresentations { get; set; }
        public DbSet<lessonResult> lessonResults { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CourseMapping());

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
