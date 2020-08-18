using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleCCOMapConfiguration : IEntityTypeConfiguration<SampleCCOMap>
    {
        public void Configure(EntityTypeBuilder<SampleCCOMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleCCO_Original)
                .WithOne(s => s.SampleCCOMap_Original)
                .HasForeignKey<SampleCCOMap>("SampleCCO_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleCCO_Standardized)
                .WithMany(s => s.SampleCCOMaps_Standardized)
                .HasForeignKey("SampleCCO_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}