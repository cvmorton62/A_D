using System.Collections.Generic;
using System.Reflection;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Interviewer> Interviewers { get; set; }
    }
}