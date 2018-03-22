using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Data.Test.Extentions;

namespace TouchTypingGo.Data.Test.Mappings
{
    public class lessonPresentationMapping : EntityTypeConfiguration<lessonPresentation>
    {
        public override void Map(EntityTypeBuilder<lessonPresentation> builder)
        {
            builder.Property(l => l.Category)
                .HasColumnType("varchar(20)")
                .IsRequired();

        }
    }
}
