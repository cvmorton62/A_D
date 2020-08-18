using A_D.Domain.Models;
using System.Collections.Generic;

namespace A_D.Domain
{
    public class SampleEthnicity
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleEthnicityMap SampleEthnicityMap_Original { get; set; }
        public List<SampleEthnicityMap> SampleEthnicityMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}