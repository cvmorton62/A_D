using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class InterviewerEmployer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}
