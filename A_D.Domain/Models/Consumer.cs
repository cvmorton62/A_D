using System;
using System.Collections.Generic;
using VR.Domain;

namespace A_D.Domain.Models
{
    public class Consumer
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public int? SampleAgeGroup_Id { get; set; }
        public int? SampleAgency_Id { get; set; }
        public int? SampleCCO_Id { get; set; }
        public int? SampleEthnicity_Id { get; set; }
        public int? SampleGender_Id { get; set; }
        public int? SampleGeography_Id { get; set; }
        public int? SampleHomeSetting_Id { get; set; }
        public int? SampleLanguage_Id { get; set; }
        public int? SampleProgram_Id { get; set; }
        public int? SampleRace_Id { get; set; }
        public int? State_Id_Mailing { get; set; }
        public int? State_Id_Physical { get; set; }
        public string Accommodation { get; set; }
        public string AddressLine1Mailing { get; set; }
        public string AddressLine1Physical { get; set; }
        public string AddressLine2Mailing { get; set; }
        public string AddressLine2Physical { get; set; }
        public int? Age { get; set; }
        public string CaseManager { get; set; }
        public string CaseManagerEmail { get; set; }
        public string CaseManagerPhone { get; set; }
        public string CityMailing { get; set; }
        public string CityPhysical { get; set; }
        public bool ConsentForm { get; set; }
        public bool ConsentFormGuardian { get; set; }
        public DateTime? DateBIRequest { get; set; }
        public DateTime? DateBIResponse { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateReturnedLetter { get; set; }
        public DateTime? DateVerificationSheet { get; set; }
        public bool DoNotAssign { get; set; }
        public bool DoNotAssignTargetMet { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string PlaceOfEmployment { get; set; }
        public bool SelfDirectedSupports { get; set; }
        public string SpecialInstruction { get; set; }
        public string StateIdentifier { get; set; }
        public string VRID { get; set; }
        public string ZipCodeMailing { get; set; }
        public string ZipCodePhysical { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public SampleAgeGroup SampleAgeGroup { get; set; }
        public SampleAgency SampleAgency { get; set; }
        public SampleCCO SampleCCO { get; set; }
        public SampleEthnicity SampleEthnicity { get; set; }
        public SampleGender SampleGender { get; set; }
        public SampleGeography SampleGeography { get; set; }
        public SampleHomeSetting SampleHomeSetting { get; set; }
        public SampleLanguage SampleLanguage { get; set; }
        public SampleProgram SampleProgram { get; set; }
        public SampleRace SampleRace { get; set; }
        public State StateMailing { get; set; }
        public State StatePhysical { get; set; }
        public List<ConsumerContact> ConsumerContacts { get; set; }
        public ConsumerGuardian ConsumerGuardian { get; set; }
        public List<ConsumerNote> ConsumerNotes { get; set; }
        public Assignment Assignment { get; set; }
    }
}
