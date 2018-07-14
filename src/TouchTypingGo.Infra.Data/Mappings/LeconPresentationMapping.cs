using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class LessonPresentationMapping : IEntityTypeConfiguration<LessonPresentation>
    {
        public void Configure(EntityTypeBuilder<LessonPresentation> builder)
        {
            builder.HasMany(x => x.LessonResults)
                .WithOne(x => x.LessonPresentation)
                .HasForeignKey(x => x.LessonPresentationId);

            builder.Property(l => l.Category)
                .HasColumnType("varchar(20)")
                .IsRequired();
            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("LessonPresentation");
        }
    }
}
