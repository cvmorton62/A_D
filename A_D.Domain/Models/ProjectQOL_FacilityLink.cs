namespace A_D.Domain.Models
{
    public class ProjectQOL_FacilityLink
    {
        public int Id { get; set; }
        public int ProjectQOL_Facility_Id_A { get; set; }
        public int ProjectQOL_Facility_Id_B { get; set; }
        public bool CoSchedule { get; set; }
        public ProjectQOL_Facility ProjectQOL_FacilityA { get; set; }
        public ProjectQOL_Facility ProjectQOL_FacilityB { get; set; }
    }
}
