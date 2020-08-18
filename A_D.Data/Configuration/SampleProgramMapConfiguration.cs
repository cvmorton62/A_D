using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleProgramMapConfiguration : IEntityTypeConfiguration<SampleProgramMap>
    {
        public void Configure(EntityTypeBuilder<SampleProgramMap> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SampleProgram_Original)
                .WithOne(s => s.SampleProgramMap_Original)
                .HasForeignKey<SampleProgramMap>("SampleProgram_Id_Original")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.SampleProgram_Standardized)
                .WithMany(s => s.SampleProgramMaps_Standardized)
                .HasForeignKey("SampleProgram_Id_Standardized")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}