using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SurveyQOLConfiguration : IEntityTypeConfiguration<SurveyQOL>
    {
        public void Configure(EntityTypeBuilder<SurveyQOL> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Interviewer)
                .WithMany(i => i.SurveysQOL)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.ProjectQOL_Facility)
                .WithMany(p => p.SurveysQOL)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.ResultCodeQOLIncomplete)
                .WithMany(r => r.SurveysQOL)
                .HasForeignKey("IncompleteCode_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.AdmitDay).HasMaxLength(2);
            builder.Property(s => s.AdmitMonth).HasMaxLength(2);
            builder.Property(s => s.AdmitYear).HasMaxLength(4);
            builder.Property(s => s.Assisted).HasMaxLength(1);
            builder.Property(s => s.AssistedBy).HasMaxLength(1);
            builder.Property(s => s.Consent).HasMaxLength(1);
            builder.Property(s => s.Gender).HasMaxLength(1);
            builder.Property(s => s.Initials).HasMaxLength(2);
            builder.Property(s => s.InterviewNumber).HasMaxLength(8);
            builder.Property(s => s.InterviewTime).HasMaxLength(5);
            builder.Property(s => s.Questions).HasMaxLength(100);
            builder.Property(s => s.RID).HasMaxLength(3);
            builder.Property(s => s.DateStart).HasColumnType("date");
            builder.Property(s => s.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(s => s.SourceCreate).HasMaxLength(200);
            builder.Property(s => s.SourceModify).HasMaxLength(200);
        }
    }
}
