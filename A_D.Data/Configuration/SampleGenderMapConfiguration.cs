using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleGenderMapConfiguration : IEntityTypeConfiguration<SampleGenderMap>
    {
        public void Configure(EntityTypeBuilder<SampleGenderMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleGender_Original)
                .WithOne(s => s.SampleGenderMap_Original)
                .HasForeignKey<SampleGenderMap>("SampleGender_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleGender_Standardized)
                .WithMany(s => s.SampleGenderMaps_Standardized)
                .HasForeignKey("SampleGender_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}