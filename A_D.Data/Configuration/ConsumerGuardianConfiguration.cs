using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ConsumerGuardianConfiguration : IEntityTypeConfiguration<ConsumerGuardian>
    {
        public void Configure(EntityTypeBuilder<ConsumerGuardian> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Consumer)
                .WithOne(c => c.ConsumerGuardian)
                .HasForeignKey<ConsumerGuardian>("Consumer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.State)
                .WithMany(s => s.ConsumerGuardians)
                .HasForeignKey("State_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.AddressLine1).HasMaxLength(100);
            builder.Property(c => c.AddressLine2).HasMaxLength(100);
            builder.Property(c => c.City).HasMaxLength(100);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.PhoneHome).HasMaxLength(15);
            builder.Property(c => c.PhoneMobile).HasMaxLength(15);
            builder.Property(c => c.PhoneWork).HasMaxLength(15);
            builder.Property(c => c.ZipCode).HasMaxLength(15);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
        }
    }
}