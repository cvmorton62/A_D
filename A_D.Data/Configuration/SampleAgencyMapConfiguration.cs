using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleAgencyMapConfiguration : IEntityTypeConfiguration<SampleAgencyMap>
    {
        public void Configure(EntityTypeBuilder<SampleAgencyMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleAgency_Original)
                .WithOne(s => s.SampleAgencyMap_Original)
                .HasForeignKey<SampleAgencyMap>("SampleAgency_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleAgency_Standardized)
                .WithMany(s => s.SampleAgencyMaps_Standardized)
                .HasForeignKey("SampleAgency_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}