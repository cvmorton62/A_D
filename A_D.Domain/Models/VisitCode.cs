using System;
using System.Collections.Generic;
using System.Text;

namespace A_D.Domain.Models
{
    public class VisitCode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectQOL_FacilitySchedule> ProjectQOL_FacilitySchedules { get; set; }
    }
}
