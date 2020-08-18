using System;

namespace A_D.Domain.Models
{
    public class NotInterviewedQOL
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public int ResultCodeQOLNotInterviewed_Id { get; set; }
        public bool Exclude { get; set; }
        public string InterviewNumber { get; set; }
        public string RID { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Interviewer Interviewer { get; set; }
        public ResultCodeQOLNotInterviewed ResultCodeQOLNotInterviewed { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
    }
}