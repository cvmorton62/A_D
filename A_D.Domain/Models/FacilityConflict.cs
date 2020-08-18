namespace A_D.Domain.Models
{
    public class FacilityConflict
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int ProjectQOL_Facility_Id { get; set; }
        public string Comment { get; set; }
        public Interviewer Interviewer { get; set; }
        public ProjectQOL_Facility ProjectQOL_Facility { get; set; }
    }
}
