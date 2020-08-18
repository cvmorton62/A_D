namespace VR.Domain
{
    public class SampleEthnicityMap
    {
        public int Id { get; set; }
        public int SampleEthnicity_Id_Original { get; set; }
        public int SampleEthnicity_Id_Standardized { get; set; }
        public SampleEthnicity SampleEthnicity_Original { get; set; }
        public SampleEthnicity SampleEthnicity_Standardized { get; set; }
    }
}