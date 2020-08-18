using System;

namespace A_D.Domain.Models
{
    public class ProjectQOL_FacilitySchedule_Interviewer
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int ProjectQOL_FacilitySchedule_Id { get; set; }
        public bool FacilityOrganizer { get; set; }
        public bool QAM { get; set; }
        public DateTime DateCreate{ get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Interviewer Interviewer { get; set; }
        public ProjectQOL_FacilitySchedule ProjectQOL_FacilitySchedule { get; set; }
    }
}
