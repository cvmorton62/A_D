using A_D.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_D.Data.Configuration
{
    public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.SampleAgeGroup)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleAgeGroup_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleAgency)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleAgency_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleCCO)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleCCO_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleEthnicity)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleEthnicity_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleGender)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleGender_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleGeography)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleGeography_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleHomeSetting)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleHomeSetting_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleLanguage)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleLanguage_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleProgram)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleProgram_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.SampleRace)
                .WithMany(s => s.Consumers)
                .HasForeignKey("SampleRace_Id")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.StateMailing).WithMany(s => s.ConsumersMailing).HasForeignKey("State_Id_Mailing").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.StatePhysical)
                .WithMany(s => s.ConsumersPhysical)
                .HasForeignKey("State_Id_Physical")
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Accommodation).HasMaxLength(1000);
            builder.Property(c => c.AddressLine1Mailing).HasMaxLength(100);
            builder.Property(c => c.AddressLine1Physical).HasMaxLength(100);
            builder.Property(c => c.AddressLine2Mailing).HasMaxLength(100);
            builder.Property(c => c.AddressLine2Physical).HasMaxLength(100);
            builder.Property(c => c.CaseManager).HasMaxLength(100);
            builder.Property(c => c.CaseManagerEmail).HasMaxLength(100);
            builder.Property(c => c.CaseManagerPhone).HasMaxLength(20);
            builder.Property(c => c.CityMailing).HasMaxLength(100);
            builder.Property(c => c.CityPhysical).HasMaxLength(100);
            builder.Property(c => c.DateBIRequest).HasColumnType("date");
            builder.Property(c => c.DateBIResponse).HasColumnType("date");
            builder.Property(c => c.DateOfBirth).HasColumnType("date");
            builder.Property(c => c.DateReturnedLetter).HasColumnType("date");
            builder.Property(c => c.DateVerificationSheet).HasColumnType("date");
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.PhoneHome).HasMaxLength(15);
            builder.Property(c => c.PhoneMobile).HasMaxLength(15);
            builder.Property(c => c.PhoneWork).HasMaxLength(15);
            builder.Property(c => c.PlaceOfEmployment).HasMaxLength(100);
            builder.Property(c => c.SpecialInstruction).HasMaxLength(1000);
            builder.Property(c => c.StateIdentifier).HasMaxLength(100);
            builder.Property(c => c.VRID).HasMaxLength(10);
            builder.HasIndex(c => c.VRID);
            builder.Property(c => c.ZipCodeMailing).HasMaxLength(15);
            builder.Property(c => c.ZipCodePhysical).HasMaxLength(15);
            builder.Property(c => c.DateCreate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(c => c.SourceCreate).HasMaxLength(200);
            builder.Property(c => c.SourceModify).HasMaxLength(200);
            builder.HasIndex(c => new { c.Sample_Id, c.VRID }).IsUnique();
        }
    }
}