using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Data.Test.Extentions;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Data.Test.Mappings
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public override void Map(EntityTypeBuilder<Course> builder)
        {

            builder.Property(c => c.Code)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(c => c.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Courses");
        }
    }
}
