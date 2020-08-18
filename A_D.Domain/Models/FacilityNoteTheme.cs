using A_D.Domain.Models;
using System.Collections.Generic;

namespace VR.Domain
{
    public class FacilityNoteTheme
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public List<FacilityNote> FacilityNotes { get; set; }
    }
}