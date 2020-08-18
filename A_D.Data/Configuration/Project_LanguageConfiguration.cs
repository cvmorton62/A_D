using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class Project_LanguageConfiguration : IEntityTypeConfiguration<Project_Language>
    {
        public void Configure(EntityTypeBuilder<Project_Language> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Project)
                .WithMany(p => p.Projects_Languages)
                .HasForeignKey("Project_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Language)
                .WithMany(l => l.Projects_Languages)
                .HasForeignKey("Language_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new {p.Project_Id, p.Language_Id}).IsUnique();
        }
    }
}