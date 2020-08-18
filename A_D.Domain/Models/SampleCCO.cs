using System.Collections.Generic;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class SampleCCO
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleCCOMap SampleCCOMap_Original { get; set; }
        public List<SampleCCOMap> SampleCCOMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}