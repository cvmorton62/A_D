using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class InterviewerNoteConfiguration : IEntityTypeConfiguration<InterviewerNote>
    {
        public void Configure(EntityTypeBuilder<InterviewerNote> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.Interviewer)
                .WithMany(i => i.InterviewerNotes)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.InterviewerNoteTheme)
                .WithMany(i => i.InterviewerNotes)
                .HasForeignKey("InterviewerNoteTheme_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.User)
                .WithMany(u => u.InterviewerNotes)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(i => i.Note).IsRequired().HasMaxLength(1000);
            builder.Property(i => i.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(i => i.SourceCreate).HasMaxLength(200);
            builder.Property(i => i.SourceModify).HasMaxLength(200);
        }
    }
}