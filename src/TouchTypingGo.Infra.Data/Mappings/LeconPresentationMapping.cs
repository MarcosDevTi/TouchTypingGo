using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class LeconPresentationMapping : EntityTypeConfiguration<LeconPresentation>
    {
        public override void Map(EntityTypeBuilder<LeconPresentation> builder)
        {
            builder.Property(l => l.Category)
                .HasColumnType("varchar(20)")
                .IsRequired();
            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("LeconPresentation");
        }
    }
}
