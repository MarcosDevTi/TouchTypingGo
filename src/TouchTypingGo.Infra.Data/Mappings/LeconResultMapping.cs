using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class LeconResultMapping : EntityTypeConfiguration<LeconResult>
    {
        public override void Map(EntityTypeBuilder<LeconResult> builder)
        {
            builder.Property(l => l.ErrorKey)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.HasOne(lr => lr.LeconPresentation)
                .WithMany(la => la.LeconResults)
                .HasForeignKey(lr => lr.LeconPresentationId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("LeconResult");
        }
    }
}
