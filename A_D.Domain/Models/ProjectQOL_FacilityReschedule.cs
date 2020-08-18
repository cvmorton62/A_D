using System;
using System.Collections.Generic;
using System.Text;

namespace A_D.Domain.Models
{
    public class ProjectQOL_FacilityReschedule
    {
        public int Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public int RescheduleReason_Id { get; set; }
        public DateTime DateScheduleOriginal { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
        public RescheduleReason RescheduleReason { get; set; }
    }
}