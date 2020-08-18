using A_D.Domain.Models;
using System.Collections.Generic;

namespace A_D.Domain
{
    public class SampleLanguage
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public string Name { get; set; }
        public SampleLanguageMap SampleLanguageMap_Original { get; set; }
        public List<SampleLanguageMap> SampleLanguageMaps_Standardized { get; set; }
        public List<Consumer> Consumers { get; set; }
    }
}