using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class PSARegionConfiguration : IEntityTypeConfiguration<PSARegion>
    {
        public void Configure(EntityTypeBuilder<PSARegion> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.ProjectQOL)
                .WithMany(p => p.PSARegions)
                .HasForeignKey("ProjectQOL_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(p => new { p.ProjectQOL_Id, p.Name }).IsUnique();
        }
    }
}