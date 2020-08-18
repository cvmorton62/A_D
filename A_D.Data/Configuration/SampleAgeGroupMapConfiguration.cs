using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VR.Domain;

namespace A_D.Data.Configuration
{
    public class SampleAgeGroupMapConfiguration : IEntityTypeConfiguration<SampleAgeGroupMap>
    {
        public void Configure(EntityTypeBuilder<SampleAgeGroupMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleAgeGroup_Original)
                .WithOne(s => s.SampleAgeGroupMap_Original)
                .HasForeignKey<SampleAgeGroupMap>("SampleAgeGroup_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleAgeGroup_Standardized)
                .WithMany(s => s.SampleAgeGroupMaps_Standardized)
                .HasForeignKey("SampleAgeGroup_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}