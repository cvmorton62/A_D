using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class SampleConfiguration : IEntityTypeConfiguration<Sample>
    {
        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.ProjectNCI)
                .WithMany(p => p.Samples)
                .HasForeignKey("ProjectNCI_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(s => new {s.ProjectNCI_Id, s.Name}).IsUnique();
            builder.Property(s => s.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(s => s.SourceCreate).HasMaxLength(200);
            builder.Property(s => s.SourceModify).HasMaxLength(200);
        }
    }
}