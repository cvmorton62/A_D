using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VR.Domain;

namespace A_D.Data.Configuration
{
    public class SampleHomeSettingMapConfiguration : IEntityTypeConfiguration<SampleHomeSettingMap>
    {
        public void Configure(EntityTypeBuilder<SampleHomeSettingMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleHomeSetting_Original)
                .WithOne(s => s.SampleHomeSettingMap_Original)
                .HasForeignKey<SampleHomeSettingMap>("SampleHomeSetting_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleHomeSetting_Standardized)
                .WithMany(s => s.SampleHomeSettingMaps_Standardized)
                .HasForeignKey("SampleHomeSetting_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}