using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleGenderConfiguration : IEntityTypeConfiguration<SampleGender>
    {
        public void Configure(EntityTypeBuilder<SampleGender> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Sample_Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(s => s.Name).IsUnique();
        }
    }
}