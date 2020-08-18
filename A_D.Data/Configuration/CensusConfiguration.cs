using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class CensusConfiguration:IEntityTypeConfiguration<Census>
    {
        public void Configure(EntityTypeBuilder<Census> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.ProjectQOL_Facility)
                .WithMany(p => p.Censuses)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.RepresentativeSurveyBatch)
                .WithMany(r => r.Censuses)
                .HasForeignKey("RepresentativeSurveyBatch_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.RepresentativeSurveyMethod)
                .WithMany(r => r.Censuses)
                .HasForeignKey("RepresentativeSurveyMethod_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.StateRepresentative)
                .WithMany(s => s.Censuses)
                .HasForeignKey("State_Id_Representative")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.RepresentativeAddress).HasMaxLength(100);
            builder.Property(c => c.RepresentativeCity).HasMaxLength(100);
            builder.Property(c => c.RepresentativeEmail).HasMaxLength(100);
            builder.Property(c => c.RepresentativeNameFirst).HasMaxLength(100);
            builder.Property(c => c.RepresentativeNameLast).HasMaxLength(100);
            builder.Property(c => c.RepresentativePhone).HasMaxLength(15);
            builder.Property(c => c.RepresentativeZipCode).HasMaxLength(15);
            builder.Property(c => c.ResidentNameFirst).HasMaxLength(100);
            builder.Property(c => c.ResidentNameLast).HasMaxLength(100);
            builder.Property(c => c.RID).HasMaxLength(3);
            builder.Property(c => c.RoomNumber).HasMaxLength(100);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
        }
    }
}
