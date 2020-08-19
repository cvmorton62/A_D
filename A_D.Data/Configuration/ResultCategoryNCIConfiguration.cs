using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ResultCategoryNCIConfiguration : IEntityTypeConfiguration<ResultCategoryNCI>
    {
        public void Configure(EntityTypeBuilder<ResultCategoryNCI> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}
