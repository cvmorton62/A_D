using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VR.Domain;

namespace A_D.Data.Configuration
{
    public class IncentiveConfiguration : IEntityTypeConfiguration<Incentive>
    {
        public void Configure(EntityTypeBuilder<Incentive> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(i => i.Sample)
                .WithMany(s => s.Incentives)
                .HasForeignKey("Sample_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(i => new { i.Sample_Id, i.Amount }).IsUnique();
            builder.Property(i => i.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(i => i.SourceCreate).HasMaxLength(200);
            builder.Property(i => i.SourceModify).HasMaxLength(200);
        }
    }
}