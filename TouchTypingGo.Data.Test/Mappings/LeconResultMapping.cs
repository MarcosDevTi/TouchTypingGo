using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Data.Test.Extentions;

namespace TouchTypingGo.Data.Test.Mappings
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
        }
    }
}
