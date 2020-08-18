using A_D.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    internal class InterviewerNoteThemeConfiguration : IEntityTypeConfiguration<InterviewerNoteTheme>
    {
        public void Configure(EntityTypeBuilder<InterviewerNoteTheme> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Definition).IsRequired().HasMaxLength(100);
            builder.HasIndex(i => i.Definition).IsUnique();
            builder.Property(i => i.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(i => i.Name).IsUnique();
        }
    }
}