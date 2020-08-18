using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectNCIConfiguration : IEntityTypeConfiguration<ProjectNCI>
    {
        public void Configure(EntityTypeBuilder<ProjectNCI> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.NotifyingParty)
                .WithMany(n => n.ProjectsNCI)
                .HasForeignKey("NotifyingParty_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project)
                .WithOne(p => p.ProjectNCI)
                .HasForeignKey<ProjectNCI>("Project_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}