using System.Collections.Generic;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class FacilityNoteConfiguration : IEntityTypeConfiguration<FacilityNote>
    {
        public void Configure(EntityTypeBuilder<FacilityNote> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasOne(f => f.Facility)
                .WithMany(f => f.FacilityNotes)
                .HasForeignKey("Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(f => f.FacilityNoteTheme)
                .WithMany(f => f.FacilityNotes)
                .HasForeignKey("FacilityNoteTheme_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(f => f.User)
                .WithMany(u => u.FacilityNotes)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(f => f.Note).IsRequired().HasMaxLength(1000);
            builder.Property(f => f.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(f => f.SourceCreate).HasMaxLength(200);
            builder.Property(f => f.SourceModify).HasMaxLength(200);
        }
    }
}