using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class LessonPresentationMapping : EntityTypeConfiguration<LessonPresentation>
    {
        public override void Map(EntityTypeBuilder<LessonPresentation> builder)
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
