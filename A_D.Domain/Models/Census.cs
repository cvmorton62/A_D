using System;

namespace A_D.Domain.Models
{
    public class Census
    {
        public int Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public int RepresentativeSurveyBatch_Id { get; set; }
        public int RepresentativeSurveyMethod_Id { get; set; }
        public int State_Id_Representative { get; set; }
        public bool AssistedLivingMedicaidWaiver { get; set; }
        public bool Ineligible { get; set; }
        public bool Invalid { get; set; }
        public string RepresentativeAddress { get; set; }
        public bool RepresentativeBlankSurvey { get; set; }
        public string RepresentativeCity { get; set; }
        public string RepresentativeEmail { get; set; }
        public string RepresentativeNameFirst { get; set; }
        public string RepresentativeNameLast { get; set; }
        public string RepresentativePhone { get; set; }
        public bool RepresentativeRefusal { get; set; }
        public DateTime RepresentativeSurveyDateImport { get; set; }
        public bool RepresentativeUninvolved { get; set; }
        public string RepresentativeZipCode { get; set; }
        public DateTime ResidentDateOfBirth { get; set; }
        public string ResidentNameFirst { get; set; }
        public string ResidentNameLast { get; set; }
        public string RID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomOrder { get; set; }
        public bool ShortTerm { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
        public RepresentativeSurveyBatch RepresentativeSurveyBatch { get; set; }
        public RepresentativeSurveyMethod RepresentativeSurveyMethod { get; set; }
        public State StateRepresentative { get; set; }
    }
}
