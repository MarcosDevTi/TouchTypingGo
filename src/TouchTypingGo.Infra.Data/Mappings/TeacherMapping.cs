using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class TeacherMapping : EntityTypeConfiguration<Teacher>
    {
        public override void Map(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(t => t.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder.Property(s => s.Email)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Teacher");
        }
    }
}
