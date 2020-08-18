using System.Collections.Generic;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class SampleHomeSetting
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleHomeSettingMap SampleHomeSettingMap_Original { get; set; }
        public List<SampleHomeSettingMap> SampleHomeSettingMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}