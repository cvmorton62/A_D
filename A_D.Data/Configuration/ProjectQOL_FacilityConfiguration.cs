using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectQOL_FacilityConfiguration : IEntityTypeConfiguration<ProjectQOL_Facility>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL_Facility> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.DocumentFormat_Representative)
                .WithMany(d => d.ProjectsQOL_FacilitiesRepresentative)
                .HasForeignKey("DocumentFormat_Id_Representative")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DocumentFormat_Resident)
                .WithMany(d => d.ProjectsQOL_FacilitiesResident)
                .HasForeignKey("DocumentFormat_Id_Resident")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Facility)
                .WithMany(f => f.ProjectsQOL_Facilities)
                .HasForeignKey("Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProjectQOL)
                .WithMany(p => p.ProjectsQOL_Facilities)
                .HasForeignKey("ProjectQOL_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PSA)
                .WithMany(p => p.ProjectsQOL_Facilities)
                .HasForeignKey("PSA_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.RepresentativeListStatus)
                .WithMany(r => r.ProjectsQOL_Facilities)
                .HasForeignKey("RepresentativeListStatus_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ReturnVisitReason)
                .WithMany(r => r.ProjectsQOL_Facilities)
                .HasForeignKey("ReturnVisitReason_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.DateContact).HasColumnType("date");
            builder.Property(p => p.DateEmailCensus).HasColumnType("date");
            builder.Property(p => p.DateEmailConfirmation).HasColumnType("date");
            builder.Property(p => p.DateEmailFollowUp).HasColumnType("date");
            builder.Property(p => p.DateEmailReminder).HasColumnType("date");
            builder.Property(p => p.DateImportRepresentativeList).HasColumnType("date");
            builder.Property(p => p.DateImportResidentList).HasColumnType("date");
            builder.Property(p => p.DateNonCompliant).HasColumnType("date");
            builder.Property(p => p.DateReceiveRepresentativeList).HasColumnType("date");
            builder.Property(p => p.DateReceiveResidentList).HasColumnType("date");
            builder.Property(p => p.NonCompliantComment).HasMaxLength(1000);
            builder.Property(p => p.RepresentativeListNote).HasMaxLength(1000);
            builder.Property(p => p.ResidentListNote).HasMaxLength(1000);
            builder.Property(p => p.ScheduleNote).HasMaxLength(1000);
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}
