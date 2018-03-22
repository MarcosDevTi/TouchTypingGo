using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class LessonResultMapping : EntityTypeConfiguration<LessonResult>
    {
        public override void Map(EntityTypeBuilder<LessonResult> builder)
        {
            builder.Property(l => l.ErrorKey)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.HasOne(lr => lr.LessonPresentation)
                .WithMany(la => la.LessonResults)
                .HasForeignKey(lr => lr.LessonPresentationId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("LessonResult");
        }
    }
}
