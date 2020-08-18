using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class DeviceNoteConfiguration : IEntityTypeConfiguration<DeviceNote>
    {
        public void Configure(EntityTypeBuilder<DeviceNote> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.Device)
                .WithMany(d => d.DeviceNotes)
                .HasForeignKey("Device_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.User)
                .WithMany(u => u.DeviceNotes)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Note).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
        }
    }
}