using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleRateResidentConfiguration : IEntityTypeConfiguration<SampleRateResident>
    {
        public void Configure(EntityTypeBuilder<SampleRateResident> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.ProjectQOL)
                .WithMany(p => p.SampleRatesResident)
                .HasForeignKey("ProjectQOL_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(s => new { s.ProjectQOL_Id, s.SampleCount }).IsUnique();
        }
    }
}