namespace A_D.Domain.Models
{
    public class FacilityDistance
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public double Miles { get; set; }
        public Interviewer Interviewer { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
    }
}
