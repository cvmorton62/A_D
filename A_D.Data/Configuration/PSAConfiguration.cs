using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class PSAConfiguration : IEntityTypeConfiguration<PSA>
    {
        public void Configure(EntityTypeBuilder<PSA> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.PSARegion)
                .WithMany(p => p.PSAs)
                .HasForeignKey("PSARegion_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(p => new { p.PSARegion_Id, p.Name }).IsUnique();
        }
    }
}
