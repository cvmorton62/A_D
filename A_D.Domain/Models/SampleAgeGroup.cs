using System.Collections.Generic;
using System.Reflection;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class SampleAgeGroup
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleAgeGroupMap SampleAgeGroupMap_Original { get; set; }
        public List<SampleAgeGroupMap> SampleAgeGroupMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}