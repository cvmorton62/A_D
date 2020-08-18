using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ResultCodeQOLNotInterviewedConfiguration : IEntityTypeConfiguration<ResultCodeQOLNotInterviewed>
    {
        public void Configure(EntityTypeBuilder<ResultCodeQOLNotInterviewed> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Definition).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Definition).IsUnique();
            builder.Property(r => r.Number).IsRequired().HasMaxLength(2);
            builder.HasIndex(r => r.Number).IsUnique();
        }
    }
}