using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SeparationReasonConfiguration : IEntityTypeConfiguration<SeparationReason>
    {
        public void Configure(EntityTypeBuilder<SeparationReason> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(15);
            builder.HasIndex(s => s.Name).IsUnique();
        }
    }
}
