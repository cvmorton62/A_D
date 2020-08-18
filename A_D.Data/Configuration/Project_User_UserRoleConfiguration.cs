using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class Project_User_UserRoleConfiguration : IEntityTypeConfiguration<Project_User_UserRole>
    {
        public void Configure(EntityTypeBuilder<Project_User_UserRole> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Project)
                .WithMany(p => p.Projects_Users_UserRoles)
                .HasForeignKey("Project_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.User)
                .WithMany(u => u.Projects_Users_UserRoles)
                .HasForeignKey("User_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => new { p.Project_Id, p.User_Id }).IsUnique();
            builder.HasOne(p => p.UserRole)
                .WithMany(u => u.Projects_Users_UserRoles)
                .HasForeignKey("UserRole_Id")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}