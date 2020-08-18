using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectQOL_FacilityLinkConfiguration:IEntityTypeConfiguration<ProjectQOL_FacilityLink>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL_FacilityLink> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.ProjectQOL_FacilityA)
                .WithMany(p => p.ProjectQOL_FacilityLinksA)
                .HasForeignKey("ProjectQOL_Facility_Id_A")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProjectQOL_FacilityB)
                .WithMany(p => p.ProjectQOL_FacilityLinksB)
                .HasForeignKey("ProjectQOL_Facility_Id_B")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new {p.ProjectQOL_Facility_Id_A, p.ProjectQOL_Facility_Id_B}).IsUnique();
        }
    }
}
