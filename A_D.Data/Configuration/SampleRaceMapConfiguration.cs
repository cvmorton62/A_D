using AD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleRaceMapConfiguration : IEntityTypeConfiguration<SampleRaceMap>
    {
        public void Configure(EntityTypeBuilder<SampleRaceMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleRace_Original)
                .WithOne(s => s.SampleRaceMap_Original)
                .HasForeignKey<SampleRaceMap>("SampleRace_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleRace_Standardized)
                .WithMany(s => s.SampleRaceMaps_Standardized)
                .HasForeignKey("SampleRace_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}