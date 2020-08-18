using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleEthnicityMapConfiguration : IEntityTypeConfiguration<SampleEthnicityMap>
    {
        public void Configure(EntityTypeBuilder<SampleEthnicityMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleEthnicity_Original)
                .WithOne(s => s.SampleEthnicityMap_Original)
                .HasForeignKey<SampleEthnicityMap>("SampleEthnicity_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleEthnicity_Standardized)
                .WithMany(s => s.SampleEthnicityMaps_Standardized)
                .HasForeignKey("SampleEthnicity_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}