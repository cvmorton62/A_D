using System.Collections.Generic;
using A_D.Domain.Models;

namespace VR.Domain
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