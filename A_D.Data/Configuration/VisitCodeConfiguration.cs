using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class VisitCodeConfiguration : IEntityTypeConfiguration<VisitCode>
    {
        public void Configure(EntityTypeBuilder<VisitCode> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(v => v.Name).IsUnique();
        }
    }
}
