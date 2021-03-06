﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Infra.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
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

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Addresses");
        }
    }
}
