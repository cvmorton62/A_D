using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectQOL_FacilityScheduleConfiguration : IEntityTypeConfiguration<ProjectQOL_FacilitySchedule>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL_FacilitySchedule> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.ProjectQOL_Facility)
                .WithMany(p => p.ProjectQOL_FacilitySchedules)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.VisitCode)
                .WithMany(v => v.ProjectQOL_FacilitySchedules)
                .HasForeignKey("VisitCode_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.Date).HasColumnType("date");
            builder.HasIndex(p => new { p.ProjectQOL_Facility_Id, p.VisitCode_Id }).IsUnique();
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}
