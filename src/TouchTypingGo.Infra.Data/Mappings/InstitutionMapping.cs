using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Institution;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class InstitutionMapping : EntityTypeConfiguration<Institution>
    {
        public override void Map(EntityTypeBuilder<Institution> builder)
        {

            builder.Property(c => c.Name)
                .HasColumnType("varchar(60)")
                .IsRequired();
            builder.Property(c => c.Email)
                .HasColumnType("varchar(60)")
                .IsRequired();
            builder.Property(c => c.Phone)
                .HasColumnType("varchar(40)")
                .IsRequired();
            builder.HasOne(x => x.Address)
                .WithOne(x => x.Institution)
                .HasForeignKey<Institution>(a=>a.AddressId)
                .OnDelete(DeleteBehavior.Cascade);

                builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Institutions");
        }
    }
}
