using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class NotInterviewedQOLConfiguration : IEntityTypeConfiguration<NotInterviewedQOL>
    {
        public void Configure(EntityTypeBuilder<NotInterviewedQOL> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasOne(n => n.Interviewer)
                .WithMany(i => i.NotInterviewedsQOL)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(n => n.ProjectQOL_Facility)
                .WithMany(p => p.NotInterviewedsQOL)
                .HasForeignKey("ProjectQOL_Facility_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(n => n.ResultCodeQOLNotInterviewed)
                .WithMany(r => r.NotInterviewedsQOL)
                .HasForeignKey("NotInterviewedCode_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.InterviewNumber).HasMaxLength(8);
            builder.Property(s => s.RID).HasMaxLength(3);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
        }
    }
}
