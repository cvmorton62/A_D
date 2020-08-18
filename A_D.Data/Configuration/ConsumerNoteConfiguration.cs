using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ConsumerNoteConfiguration : IEntityTypeConfiguration<ConsumerNote>
    {
        public void Configure(EntityTypeBuilder<ConsumerNote> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Consumer)
                .WithMany(c => c.ConsumerNotes)
                .HasForeignKey("Consumer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.User)
                .WithMany(u => u.ConsumerNotes)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Caller).HasMaxLength(100);
            builder.Property(c => c.Comment).HasMaxLength(1000);
            builder.Property(c => c.DateInterviewerNotified).HasColumnType("date");
            builder.Property(c => c.Note).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.Phone).HasMaxLength(15);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
        }
    }
}