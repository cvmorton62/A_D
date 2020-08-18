using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VR.Domain;

namespace A_D.Data.Configuration
{
    public class SampleLanguageMapConfiguration : IEntityTypeConfiguration<SampleLanguageMap>
    {
        public void Configure(EntityTypeBuilder<SampleLanguageMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleLanguage_Original)
                .WithOne(s => s.SampleLanguageMap_Original)
                .HasForeignKey<SampleLanguageMap>("SampleLanguage_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleLanguage_Standardized)
                .WithMany(s => s.SampleLanguageMaps_Standardized)
                .HasForeignKey("SampleLanguage_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}