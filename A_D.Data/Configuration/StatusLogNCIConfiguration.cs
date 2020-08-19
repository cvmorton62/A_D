using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class StatusLogNCIConfiguration : IEntityTypeConfiguration<StatusLogNCI>
    {
        public void Configure(EntityTypeBuilder<StatusLogNCI> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Consumer)
                .WithMany(c => c.StatusLogsNCI)
                .HasForeignKey("Consumer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.Interviewer)
                .WithMany(i => i.StatusLogsNCI)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.RefusalReasonNCI)
                .WithMany(r => r.StatusLogsNCI)
                .HasForeignKey("RefusalReasonNCI_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.ResultCategoryNCI)
                .WithMany(r => r.StatusLogsNCI)
                .HasForeignKey("ResultCategoryNCI_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.Date).HasColumnType("date");
            builder.Property(s => s.InterviewNumber).HasMaxLength(8);
            builder.Property(s => s.InterviewTime).HasMaxLength(5);
            builder.Property(s => s.RefusalReasonOther).HasMaxLength(100);
            builder.Property(s => s.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(s => s.SourceCreate).HasMaxLength(200);
            builder.Property(s => s.SourceModify).HasMaxLength(200);
        }
    }
}
