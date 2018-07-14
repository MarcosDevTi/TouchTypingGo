using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class CourseLessonPresentationMapping : IEntityTypeConfiguration<CourseLessonPresentation>
    {
        public void Configure(EntityTypeBuilder<CourseLessonPresentation> builder)
        {
            builder.HasKey(cl => new { cl.CourseId, cl.LessonPresentationId });

            builder.HasOne<Course>(cl => cl.Course)
                .WithMany(c => c.CourseLessonPresentations)
                .HasForeignKey(cl => cl.CourseId);

            builder.HasOne<LessonPresentation>(cl => cl.LessonPresentation)
                .WithMany(l => l.CourseLessonPresentations)
                .HasForeignKey(cl => cl.LessonPresentationId);
        }
    }
}
