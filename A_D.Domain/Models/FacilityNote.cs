using System;

namespace A_D.Domain.Models
{
    public class FacilityNote
    {
        public int Id { get; set; }
        public int Facility_Id { get; set; }
        public int FacilityNoteTheme_Id { get; set; }
        public int User_Id { get; set; }
        public string Note { get; set; }
        public bool Retain { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Facility Facility { get; set; }
        public FacilityNoteTheme FacilityNoteTheme { get; set; }
        public User User { get; set; }
    }
}