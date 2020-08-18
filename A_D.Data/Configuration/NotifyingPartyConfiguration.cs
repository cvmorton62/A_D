using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class NotifyingPartyConfiguration : IEntityTypeConfiguration<NotifyingParty>
    {
        public void Configure(EntityTypeBuilder<NotifyingParty> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(n => n.Name).IsUnique();
        }
    }
}