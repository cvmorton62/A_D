using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class RecommendationConfiguration : IEntityTypeConfiguration<Recommendation>
    {
        public void Configure(EntityTypeBuilder<Recommendation> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}