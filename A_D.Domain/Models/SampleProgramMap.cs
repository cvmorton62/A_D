namespace VR.Domain
{
    public class SampleProgramMap
    {
        public int Id { get; set; }
        public int SampleProgram_Id_Original { get; set; }
        public int SampleProgram_Id_Standardized { get; set; }
        public SampleProgram SampleProgram_Original { get; set; }
        public SampleProgram SampleProgram_Standardized { get; set; }
    }
}