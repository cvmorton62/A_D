using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Consumer)
                .WithOne(c => c.Assignment)
                .HasForeignKey<Assignment>(a => a.Consumer_Id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Interviewer)
                .WithMany(i => i.Assignments)
                .HasForeignKey("Interviewer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.PeerInterviewer)
                .WithMany(i => i.PeerAssignments)
                .HasForeignKey("Interviewer_Id_Peer")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(a => a.Date).HasColumnType("date");
            builder.Property(a => a.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(a => a.SourceCreate).HasMaxLength(200);
            builder.Property(a => a.SourceModify).HasMaxLength(200);
        }
    }
}