using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class KeyboardMapping : EntityTypeConfiguration<Keyboard>
    {
        public override void Map(EntityTypeBuilder<Keyboard> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(50)");
            builder.Property(x => x.ValHtml)
                .HasColumnType("varchar(20)");

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Keyboard");
        }
    }
}
