namespace VR.Domain
{
    public class SampleAgencyMap
    {
        public int Id { get; set; }
        public int SampleAgency_Id_Original { get; set; }
        public int SampleAgency_Id_Standardized { get; set; }
        public SampleAgency SampleAgency_Original { get; set; }
        public SampleAgency SampleAgency_Standardized { get; set; }
    }
}