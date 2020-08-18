namespace VR.Domain
{
    public class SampleGeographyMap
    {
        public int Id { get; set; }
        public int SampleGeography_Id_Original { get; set; }
        public int SampleGeography_Id_Standardized { get; set; }
        public SampleGeography SampleGeography_Original { get; set; }
        public SampleGeography SampleGeography_Standardized { get; set; }
    }
}