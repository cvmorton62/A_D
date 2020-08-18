namespace VR.Domain
{
    public class SampleLanguageMap
    {
        public int Id { get; set; }
        public int SampleLanguage_Id_Original { get; set; }
        public int SampleLanguage_Id_Standardized { get; set; }
        public SampleLanguage SampleLanguage_Original { get; set; }
        public SampleLanguage SampleLanguage_Standardized { get; set; }
    }
}