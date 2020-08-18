namespace A_D.Domain.Models
{
    public class InterviewerConflict
    {
        public int Id { get; set; }
        public int Interviewer_Id_A { get; set; }
        public int Interviewer_Id_B { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public string Comment { get; set; }
        public Interviewer InterviewerA { get; set; }
        public Interviewer InterviewerB { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
    }
}