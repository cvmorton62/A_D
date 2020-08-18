using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleRateRepresentativeConfiguration : IEntityTypeConfiguration<SampleRateRepresentative>
    {
        public void Configure(EntityTypeBuilder<SampleRateRepresentative> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.ProjectQOL)
                .WithMany(p => p.SampleRatesRepresentative)
                .HasForeignKey("ProjectQOL_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(s => new {s.ProjectQOL_Id, s.SampleCount}).IsUnique();
        }
    }
}
