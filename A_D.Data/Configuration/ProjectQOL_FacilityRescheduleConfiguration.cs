using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace A_D.Data.Configuration
{
    public class ProjectQOL_FacilityRescheduleConfiguration : IEntityTypeConfiguration<ProjectQOL_FacilityReschedule>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL_FacilityReschedule> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.ProjectQOL_Facility)
                .WithMany(p => p.ProjectQOL_FacilityReschedules)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.RescheduleReason)
                .WithMany(r => r.ProjectQOL_FacilityReschedules)
                .HasForeignKey("RescheduleReason_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.DateScheduleOriginal).HasColumnType("date");
            builder.HasIndex(p => new { p.ProjectQOL_Facility_Id, p.DateScheduleOriginal}).IsUnique();
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}
