using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VR.Domain;

namespace A_D.Data.Configuration
{
    public class PayRateConfiguration : IEntityTypeConfiguration<PayRate>
    {
        public void Configure(EntityTypeBuilder<PayRate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Sample)
                .WithMany(s => s.PayRates)
                .HasForeignKey("Sample_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new { p.Sample_Id, p.Amount }).IsUnique();
            builder.HasIndex(p => new { p.Sample_Id, p.MilesMaximum }).IsUnique();
            builder.Property(p => p.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.SourceCreate).HasMaxLength(200);
            builder.Property(p => p.SourceModify).HasMaxLength(200);
        }
    }
}
