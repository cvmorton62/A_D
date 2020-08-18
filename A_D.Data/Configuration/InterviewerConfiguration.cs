using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class InterviewerConfiguration : IEntityTypeConfiguration<Interviewer>
    {
        public void Configure(EntityTypeBuilder<Interviewer> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.Recommendation)
                .WithMany(r => r.Interviewers)
                .HasForeignKey("Recommendation_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.State)
                .WithMany(s => s.Interviewers)
                .HasForeignKey("State_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(i => i.AddressLine1).HasMaxLength(100);
            builder.Property(i => i.AddressLine2).HasMaxLength(100);
            builder.Property(i => i.City).HasMaxLength(100);
            builder.Property(i => i.Email).HasMaxLength(100);
            builder.Property(i => i.NameFirst).IsRequired().HasMaxLength(100);
            builder.Property(i => i.NameLast).IsRequired().HasMaxLength(100);
            builder.Property(i => i.NfieldId).HasMaxLength(8);
            builder.Property(i => i.Number).HasMaxLength(5);
            builder.Property(i => i.Password).HasMaxLength(15);
            builder.Property(i => i.PhoneHome).HasMaxLength(15);
            builder.Property(i => i.PhoneMobile).HasMaxLength(15);
            builder.Property(i => i.PhoneWork).HasMaxLength(15);
            builder.Property(i => i.Profession).HasMaxLength(100);
            builder.Property(i => i.UserId).HasMaxLength(100);
            builder.Property(i => i.ZipCode).HasMaxLength(15);
            builder.Property(i => i.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(i => i.SourceCreate).HasMaxLength(200);
            builder.Property(i => i.SourceModify).HasMaxLength(200);
        }
    }
}