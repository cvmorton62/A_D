using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class NotifyingParty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectNCI> ProjectsNCI { get; set; }
    }
}
