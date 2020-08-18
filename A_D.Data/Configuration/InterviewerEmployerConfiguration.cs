using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class InterviewerEmployerConfiguration : IEntityTypeConfiguration<InterviewerEmployer>
    {
        public void Configure(EntityTypeBuilder<InterviewerEmployer> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(i => i.Name).IsUnique();
        }
    }
}