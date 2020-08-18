using System.Collections.Generic;
using System.Reflection;

namespace A_D.Domain.Models
{
    public class County
    {
        public int Id { get; set; }
        public int State_Id { get; set; }
        public string Name { get; set; }
        public List<Facility> Facilities { get; set; }
        public State State { get; set; }
    }
}
