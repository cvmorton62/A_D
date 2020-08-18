using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class DeviceDeploymentConfiguration : IEntityTypeConfiguration<DeviceDeployment>
    {
        public void Configure(EntityTypeBuilder<DeviceDeployment> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.Device)
                .WithMany(d => d.DeviceDeployments)
                .HasForeignKey("Device_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Interviewer)
                .WithMany(i => i.DeviceDeployments)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.User)
                .WithMany(u => u.DeviceDeployments)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(d => d.Comment).HasMaxLength(1000);
            builder.Property(d => d.DateIssue).HasColumnType("date");
            builder.Property(d => d.DateReturn).HasColumnType("date");
            builder.Property(d => d.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(d => d.SourceCreate).HasMaxLength(200);
            builder.Property(d => d.SourceModify).HasMaxLength(200);
        }
    }
}