using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace A_D.Data.Configuration
{
    public class RefusalReasonNCIConfiguration : IEntityTypeConfiguration<RefusalReasonNCI>
    {
        public void Configure(EntityTypeBuilder<RefusalReasonNCI> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Code).IsRequired().HasMaxLength(2);
            builder.HasIndex(r => r.Code).IsUnique();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}
