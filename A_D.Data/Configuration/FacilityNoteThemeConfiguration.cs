using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    internal class FacilityNoteThemeConfiguration : IEntityTypeConfiguration<FacilityNoteTheme>
    {
        public void Configure(EntityTypeBuilder<FacilityNoteTheme> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Definition).IsRequired().HasMaxLength(100);
            builder.HasIndex(f => f.Definition).IsUnique();
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(f => f.Name).IsUnique();
        }
    }
}