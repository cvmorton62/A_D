using System;
using System.Collections.Generic;
using System.Text;
using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class RepresentativeSurveyMethodConfiguration : IEntityTypeConfiguration<RepresentativeSurveyMethod>
    {
        public void Configure(EntityTypeBuilder<RepresentativeSurveyMethod> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}