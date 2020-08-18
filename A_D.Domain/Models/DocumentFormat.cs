using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class DocumentFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_FacilitiesRepresentative { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_FacilitiesResident { get; set; }
    }
}