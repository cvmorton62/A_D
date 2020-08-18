using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.DeviceModel)
                .WithOne(d => d.Device)
                .HasForeignKey<Device>(d => d.DeviceModel_Id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.DeviceNfieldVersion)
                .WithOne(d => d.Device)
                .HasForeignKey<Device>(d => d.DeviceNfieldVersion_Id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.DeviceOS)
                .WithOne(d => d.Device)
                .HasForeignKey<Device>(d => d.DeviceOS_Id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(d => d.SerialNumber).HasMaxLength(100);
            builder.Property(d => d.VRID).HasMaxLength(10);
            builder.HasIndex(d => d.VRID).IsUnique();
            builder.Property(d => d.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(d => d.SourceCreate).HasMaxLength(200);
            builder.Property(d => d.SourceModify).HasMaxLength(200);
        }
    }
}
