using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ResultNCIConfiguration : IEntityTypeConfiguration<ResultNCI>
    {
        public void Configure(EntityTypeBuilder<ResultNCI> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.ResultCategoryNCI)
                .WithMany(r => r.ResultsNCI)
                .HasForeignKey("ResultCategoryNCI_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}