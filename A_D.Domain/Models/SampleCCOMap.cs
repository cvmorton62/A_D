namespace A_D.Domain
{
    public class SampleCCOMap
    {
        public int Id { get; set; }
        public int SampleCCO_Id_Original { get; set; }
        public int SampleCCO_Id_Standardized { get; set; }
        public SampleCCO SampleCCO_Original { get; set; }
        public SampleCCO SampleCCO_Standardized { get; set; }
    }
}