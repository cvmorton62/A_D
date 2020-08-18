using System.Collections.Generic;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class SampleAgency
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleAgencyMap SampleAgencyMap_Original { get; set; }
        public List<SampleAgencyMap> SampleAgencyMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}