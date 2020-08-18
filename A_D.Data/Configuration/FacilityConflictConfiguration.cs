using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class FacilityConflictConfiguration:IEntityTypeConfiguration<FacilityConflict>
    {
        public void Configure(EntityTypeBuilder<FacilityConflict> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.Interviewer)
                .WithMany(i => i.FacilityConflicts)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(f => f.ProjectQOL_Facility)
                .WithMany(p => p.FacilityConflicts)
                .HasForeignKey("Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(f => new {f.Interviewer_Id, f.ProjectQOL_Facility_Id}).IsUnique();
            builder.Property(f => f.Comment).HasMaxLength(1000);
        }
    }
}
