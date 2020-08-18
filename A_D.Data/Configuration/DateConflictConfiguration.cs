using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class DateConflictConfiguration : IEntityTypeConfiguration<DateConflict>
    {
        public void Configure(EntityTypeBuilder<DateConflict> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.Interviewer)
                .WithMany(i => i.DateConflicts)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(d => new { d.Interviewer_Id, d.Date }).IsUnique();
            builder.Property(d => d.Comment).HasMaxLength(1000);
        }
    }
}