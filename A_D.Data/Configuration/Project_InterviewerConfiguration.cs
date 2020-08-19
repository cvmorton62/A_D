using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class Project_InterviewerConfiguration : IEntityTypeConfiguration<Project_Interviewer>
    {
        public void Configure(EntityTypeBuilder<Project_Interviewer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Interviewer)
                .WithMany(i => i.Projects_Interviewers)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PeerInterviewer)
                .WithMany(i => i.Projects_PeerInterviewers)
                .HasForeignKey("Interviewer_Id_Peer")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.QAMInterviewer)
                .WithMany(i => i.Projects_QAMInterviewers)
                .HasForeignKey("Interviewer_Id_QAM")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project)
                .WithMany(p => p.Projects_Interviewers)
                .HasForeignKey("Project_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PSA)
                .WithMany(p => p.Projects_Interviewers)
                .HasForeignKey("PSA_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Recommendation)
                .WithMany(r => r.Projects_Interviewers)
                .HasForeignKey("Recommendation_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SeparationReason)
                .WithMany(s => s.Projects_Interviewers)
                .HasForeignKey("SeparationReason_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new { p.Interviewer_Id, p.Project_Id }).IsUnique();
            builder.Property(p => p.DateBegin).HasColumnType("date");
            builder.Property(p => p.DateEnd).HasColumnType("date");
            builder.Property(p => p.DateMaterialsIssue).HasColumnType("date");
            builder.Property(p => p.DateMaterialsReturn).HasColumnType("date");
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}