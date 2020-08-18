using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class RepresentativeSurveyBatchConfiguration : IEntityTypeConfiguration<RepresentativeSurveyBatch>
    {
        public void Configure(EntityTypeBuilder<RepresentativeSurveyBatch> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.ProjectQOL)
                .WithMany(p => p.RepresentativeSurveyBatches)
                .HasForeignKey("ProjectQOL_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(r => r.Number).IsRequired().HasMaxLength(1);
            builder.HasIndex(r => new { r.ProjectQOL_Id, r.Number }).IsUnique();
            builder.Property(r => r.DateMailDoNotCallList).HasColumnType("date");
            builder.Property(r => r.DateMailPhoneList).HasColumnType("date");
            builder.Property(r => r.DateMailPostcardList).HasColumnType("date");
            builder.Property(r => r.DateMailSurveyList).HasColumnType("date");
            builder.Property(r => r.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(r => r.SourceCreate).HasMaxLength(200);
            builder.Property(r => r.SourceModify).HasMaxLength(200);
        }
    }
}
