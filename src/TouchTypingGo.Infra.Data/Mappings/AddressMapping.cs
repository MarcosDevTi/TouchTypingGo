using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Institution;
using TouchTypingGo.Infra.Data.Extentions;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class AddressMapping : EntityTypeConfiguration<Address>
    {
        public override void Map(EntityTypeBuilder<Address> builder)
        {
            builder.Property(c => c.County)
                .HasColumnType("varchar(40)")
                .IsRequired();
            builder.Property(c => c.City)
                .HasColumnType("varchar(40)")
                .IsRequired();
            builder.Property(c => c.Number)
                .HasColumnType("varchar(10)");
            builder.Property(c => c.ZipCode)
                .HasColumnType("varchar(20)");

            //builder.HasOne(x => x.Institution)
            //    .WithOne(x => x.Address)
            //    .HasForeignKey<Institution>(i => i.AddressId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Addresses");
        }
    }
}
