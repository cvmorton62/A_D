using A_D.Domain.Models;
using System.Collections.Generic;

namespace A_D.Domain
{
    public class SampleGender
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleGenderMap SampleGenderMap_Original { get; set; }
        public List<SampleGenderMap> SampleGenderMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}