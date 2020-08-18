using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Initials).IsRequired().HasMaxLength(3);
            builder.HasIndex(u => u.Initials).IsUnique();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(u => u.Name).IsUnique();
            builder.Property(u => u.WinUserId).IsRequired().HasMaxLength(100);
            builder.HasIndex(u => u.WinUserId).IsUnique();
        }
    }
}