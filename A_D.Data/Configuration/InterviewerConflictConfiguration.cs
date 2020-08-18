using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class InterviewerConflictConfiguration : IEntityTypeConfiguration<InterviewerConflict>
    {
        public void Configure(EntityTypeBuilder<InterviewerConflict> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.InterviewerA)
                .WithMany(i => i.InterviewerAConflicts)
                .HasForeignKey("Interviewer_Id_A")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.InterviewerB)
                .WithMany(i => i.InterviewerBConflicts)
                .HasForeignKey("Interviewer_Id_B")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.ProjectQOL_Facility)
                .WithMany(p => p.InterviewerConflicts)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(i => new { i.Interviewer_Id_A, i.Interviewer_Id_B, i.ProjectQOL_Facility_Id }).IsUnique();
            builder.Property(i => i.Comment).HasMaxLength(1000);
        }
    }
}