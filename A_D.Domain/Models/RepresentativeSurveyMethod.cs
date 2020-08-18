using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class RepresentativeSurveyMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Census> Censuses { get; set; }
    }
}
