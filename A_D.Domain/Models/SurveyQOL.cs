using System;

namespace A_D.Domain.Models
{
    public class SurveyQOL
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public int ResultCodeQOLIncomplete_Id { get; set; }
        public string AdmitDay { get; set; }
        public string AdmitMonth { get; set; }
        public string AdmitYear { get; set; }
        public string Assisted { get; set; }
        public string AssistedBy { get; set; }
        public bool Completed { get; set; }
        public string Consent { get; set; }
        public DateTime DateStart { get; set; }
        public bool Exclude { get; set; }
        public string Gender { get; set; }
        public string Initials { get; set; }
        public string InterviewNumber { get; set; }
        public string InterviewTime { get; set; }
        public string Questions { get; set; }
        public string RID { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public bool TooManyNA { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ResultCodeQOLIncomplete ResultCodeQOLIncomplete { get; set; }
        public Interviewer Interviewer { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
    }
}
