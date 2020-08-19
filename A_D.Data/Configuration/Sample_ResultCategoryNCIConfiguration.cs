using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class Sample_ResultCategoryNCIConfiguration : IEntityTypeConfiguration<Sample_ResultCategoryNCI>
    {
        public void Configure(EntityTypeBuilder<Sample_ResultCategoryNCI> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Sample)
                .WithMany(s => s.Samples_ResultCategoriesNCI)
                .HasForeignKey("Sample_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.ResultCategoryNCI)
                .WithMany(r => r.Samples_ResultCategoriesNCI)
                .HasForeignKey("ResultCategoryNCI_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(s => new { s.Sample_Id, s.ResultCategoryNCI_Id }).IsUnique();
        }
    }
}
