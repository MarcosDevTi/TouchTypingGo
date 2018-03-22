using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Data.Test.Extentions;

namespace TouchTypingGo.Data.Test.Mappings
{
    public class lessonResultMapping : EntityTypeConfiguration<lessonResult>
    {
        public override void Map(EntityTypeBuilder<lessonResult> builder)
        {
            builder.Property(l => l.ErrorKey)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.HasOne(lr => lr.lessonPresentation)
                .WithMany(la => la.lessonResults)
                .HasForeignKey(lr => lr.lessonPresentationId);
        }
    }
}
