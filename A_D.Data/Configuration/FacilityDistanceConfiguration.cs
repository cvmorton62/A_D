using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class FacilityDistanceConfiguration : IEntityTypeConfiguration<FacilityDistance>
    {
        public void Configure(EntityTypeBuilder<FacilityDistance> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.Interviewer)
                .WithMany(i => i.FacilityDistances)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(f => f.ProjectQOL_Facility)
                .WithMany(p => p.FacilityDistances)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(f => new { f.Interviewer_Id, f.ProjectQOL_Facility_Id }).IsUnique();
        }
    }
}