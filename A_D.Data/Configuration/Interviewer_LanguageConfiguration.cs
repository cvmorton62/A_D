using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class Interviewer_LanguageConfiguration : IEntityTypeConfiguration<Interviewer_Language>
    {
        public void Configure(EntityTypeBuilder<Interviewer_Language> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.Interviewer)
                .WithMany(i => i.Interviewers_Languages)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.Language)
                .WithMany(l => l.Interviewers_Languages)
                .HasForeignKey("Language_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(i => new {i.Interviewer_Id, i.Language_Id}).IsUnique();
        }
    }
}