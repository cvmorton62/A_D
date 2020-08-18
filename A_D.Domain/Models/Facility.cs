using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public int County_Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int BedCount { get; set; }
        public string City { get; set; }
        public string Fax { get; set; }
        public string FID { get; set; }
        public string Name { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public County County { get; set; }
        public List<FacilityContact> FacilityContacts { get; set; }
        public List<FacilityNote> FacilityNotes { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_Facilities { get; set; }
    }
}
