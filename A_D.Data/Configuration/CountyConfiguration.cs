using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class CountyConfiguration : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.State)
                .WithMany(s => s.Counties)
                .HasForeignKey("State_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        }
    }
}
