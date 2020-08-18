using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ReturnVisitReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_Facilities { get; set; }
    }
}
