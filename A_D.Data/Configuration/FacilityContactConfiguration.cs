using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class FacilityContactConfiguration : IEntityTypeConfiguration<FacilityContact>
    {
        public void Configure(EntityTypeBuilder<FacilityContact> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.Facility)
                .WithMany(f => f.FacilityContacts)
                .HasForeignKey("Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(f => f.Email).HasMaxLength(100);
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Phone).HasMaxLength(15);
            builder.Property(f => f.PhoneExtension).HasMaxLength(10);
            builder.Property(f => f.Title).HasMaxLength(100);
            builder.Property(f => f.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(f => f.SourceCreate).HasMaxLength(200);
            builder.Property(f => f.SourceModify).HasMaxLength(200);
            builder.HasIndex(f => new { f.Facility_Id, f.Name }).IsUnique();
        }
    }
}