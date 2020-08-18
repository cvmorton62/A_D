using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.InterviewerEmployer)
                .WithMany(i => i.Projects)
                .HasForeignKey("InterviewerEmployer_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.State)
                .WithMany(s => s.Projects)
                .HasForeignKey("State_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.FolderPath).HasMaxLength(200);
            builder.Property(p => p.DateBegin).HasColumnType("date");
            builder.Property(p => p.DateEnd).HasColumnType("date");
            builder.Property(p => p.DatePHIDelete).HasColumnType("date");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.TrainingLocation).HasMaxLength(200);
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}