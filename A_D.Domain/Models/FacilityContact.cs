using System;

namespace A_D.Domain.Models
{
    public class FacilityContact
    {
        public int Id { get; set; }
        public int Facility_Id { get; set; }
        public bool Active { get; set; }
        public bool Administrator { get; set; }
        public bool CensusCoordinator { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public bool PrimaryContact { get; set; }
        public string Title { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Facility Facility { get; set; }
    }
}
