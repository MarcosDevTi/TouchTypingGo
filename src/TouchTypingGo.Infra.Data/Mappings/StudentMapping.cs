using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public override void Map(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder.Property(s => s.Email)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Student");
        }
    }
}
