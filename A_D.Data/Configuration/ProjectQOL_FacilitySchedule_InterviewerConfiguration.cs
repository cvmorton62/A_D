using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectQOL_FacilitySchedule_InterviewerConfiguration:IEntityTypeConfiguration<ProjectQOL_FacilitySchedule_Interviewer>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL_FacilitySchedule_Interviewer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Interviewer)
                .WithMany(p => p.ProjectQOL_FacilitySchedule_Interviewers)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProjectQOL_FacilitySchedule)
                .WithMany(p => p.ProjectQOL_FacilitySchedule_Interviewers)
                .HasForeignKey("ProjectQOL_FacilitySchedule_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new {p.ProjectQOL_FacilitySchedule_Id, p.Interviewer_Id}).IsUnique();
        }
    }
}
