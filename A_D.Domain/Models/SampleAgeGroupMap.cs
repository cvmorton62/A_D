namespace A_D.Domain
{
    public class SampleAgeGroupMap
    {
        public int Id { get; set; }
        public int SampleAgeGroup_Id_Original { get; set; }
        public int SampleAgeGroup_Id_Standardized { get; set; }
        public SampleAgeGroup SampleAgeGroup_Original { get; set; }
        public SampleAgeGroup SampleAgeGroup_Standardized { get; set; }
    }
}