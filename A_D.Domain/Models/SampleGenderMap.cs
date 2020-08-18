namespace A_D.Domain
{
    public class SampleGenderMap
    {
        public int Id { get; set; }
        public int SampleGender_Id_Original { get; set; }
        public int SampleGender_Id_Standardized { get; set; }
        public SampleGender SampleGender_Original { get; set; }
        public SampleGender SampleGender_Standardized { get; set; }
    }
}