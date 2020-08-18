using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Interviewer_Language> Interviewers_Languages { get; set; }
        public List<Project_Language> Projects_Languages { get; set; }
    }
}
