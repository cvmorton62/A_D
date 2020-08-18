using System;
using System.Collections.Generic;
using System.Text;

namespace A_D.Domain.Models
{
    public class ProjectQOL_FacilitySchedule
    {
        public int Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public int VisitCode_Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
        public VisitCode VisitCode { get; set; }
        public List<ProjectQOL_FacilitySchedule_Interviewer> ProjectQOL_FacilitySchedule_Interviewers { get; set; }
    }
}
