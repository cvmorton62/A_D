using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class FacilityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.County)
                .WithMany(c => c.Facilities)
                .HasForeignKey("County_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(f => f.AddressLine1).HasMaxLength(100);
            builder.Property(f => f.AddressLine2).HasMaxLength(100);
            builder.Property(f => f.City).HasMaxLength(100);
            builder.Property(f => f.Fax).HasMaxLength(15);
            builder.Property(f => f.FID).IsRequired().HasMaxLength(10);
            builder.HasIndex(f => f.FID).IsUnique();
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(f => f.Name).IsUnique();
            builder.Property(f => f.Phone1).HasMaxLength(15);
            builder.Property(f => f.Phone2).HasMaxLength(15);
            builder.Property(f => f.ZipCode).HasMaxLength(15);
            builder.Property(f => f.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(f => f.SourceCreate).HasMaxLength(200);
            builder.Property(f => f.SourceModify).HasMaxLength(200);
        }
    }
}
