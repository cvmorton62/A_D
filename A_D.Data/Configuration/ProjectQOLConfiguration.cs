using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ProjectQOLConfiguration : IEntityTypeConfiguration<ProjectQOL>
    {
        public void Configure(EntityTypeBuilder<ProjectQOL> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Project)
                .WithOne(p => p.ProjectQOL)
                .HasForeignKey<ProjectQOL>("Project_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}