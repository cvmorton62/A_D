﻿using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class RepresentativeListStatusConfiguration : IEntityTypeConfiguration<RepresentativeListStatus>
    {
        public void Configure(EntityTypeBuilder<RepresentativeListStatus> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(d => d.Name).IsUnique();
        }
    }
}