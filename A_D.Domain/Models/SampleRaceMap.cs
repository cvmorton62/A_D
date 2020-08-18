using A_D.Domain;

namespace AD.Domain
{
    public class SampleRaceMap
    {
        public int Id { get; set; }
        public int SampleRace_Id_Original { get; set; }
        public int SampleRace_Id_Standardized { get; set; }
        public SampleRace SampleRace_Original { get; set; }
        public SampleRace SampleRace_Standardized { get; set; }
    }
}