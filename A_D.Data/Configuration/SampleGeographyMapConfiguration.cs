using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleGeographyMapConfiguration : IEntityTypeConfiguration<SampleGeographyMap>
    {
        public void Configure(EntityTypeBuilder<SampleGeographyMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleGeography_Original)
                .WithOne(s => s.SampleGeographyMap_Original)
                .HasForeignKey<SampleGeographyMap>("SampleGeography_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleGeography_Standardized)
                .WithMany(s => s.SampleGeographyMaps_Standardized)
                .HasForeignKey("SampleGeography_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}