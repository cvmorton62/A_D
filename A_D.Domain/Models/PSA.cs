using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class PSA
    {
        public int Id { get; set; }
        public int PSARegion_Id { get; set; }
        public string Name { get; set; }
        public PSARegion PSARegion { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_Facilities { get; set; }
    }
}
