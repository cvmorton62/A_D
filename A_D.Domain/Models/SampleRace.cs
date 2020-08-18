using System.Collections.Generic;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class SampleRace
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleRaceMap SampleRaceMap_Original { get; set; }
        public List<SampleRaceMap> SampleRaceMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}