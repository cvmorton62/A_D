using System;
using System.Collections.Generic;
using System.Text;

namespace A_D.Domain.Models
{
    public class RescheduleReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectQOL_FacilityReschedule> ProjectQOL_FacilityReschedules { get; set; }
    }
}