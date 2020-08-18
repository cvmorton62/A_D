using A_D.Domain.Models;
using System.Collections.Generic;

namespace A_D.Domain
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Interviewer> Interviewers { get; set; }
    }
}