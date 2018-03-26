using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class CourseLessonPresentationMapping : EntityTypeConfiguration<CourseLessonPresentation>
    {
        public override void Map(EntityTypeBuilder<CourseLessonPresentation> builder)
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
