using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class RestartQOLConfiguration : IEntityTypeConfiguration<RestartQOL>
    {
        public void Configure(EntityTypeBuilder<RestartQOL> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.Interviewer)
                .WithMany(i => i.RestartsQOL)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.ResultCodeQOLIncomplete)
                .WithMany(i => i.RestartsQOL)
                .HasForeignKey("ResultCodeQOLIncomplete_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.ProjectQOL_Facility)
                .WithMany(p => p.RestartsQOL)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(r => r.AdmitDay).HasMaxLength(2);
            builder.Property(r => r.AdmitMonth).HasMaxLength(2);
            builder.Property(r => r.AdmitYear).HasMaxLength(4);
            builder.Property(r => r.Assisted).HasMaxLength(1);
            builder.Property(r => r.AssistedBy).HasMaxLength(1);
            builder.Property(r => r.Consent).HasMaxLength(1);
            builder.Property(r => r.Gender).HasMaxLength(1);
            builder.Property(r => r.Initials).HasMaxLength(2);
            builder.Property(r => r.InterviewNumber).HasMaxLength(8);
            builder.Property(r => r.InterviewTime).HasMaxLength(5);
            builder.Property(r => r.Questions).HasMaxLength(100);
            builder.Property(r => r.RID).HasMaxLength(3);
            builder.Property(r => r.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(r => r.SourceCreate).HasMaxLength(200);
            builder.Property(r => r.SourceModify).HasMaxLength(200);
        }
    }
}
