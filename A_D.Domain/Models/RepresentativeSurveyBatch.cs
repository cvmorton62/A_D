using System;
using System.Collections.Generic;
using System.Text;

namespace A_D.Domain.Models
{
    public class RepresentativeSurveyBatch
    {
        public int Id { get; set; }
        public int ProjectQOL_Id { get; set; }
        public DateTime DateMailDoNotCallList { get; set; }
        public DateTime DateMailPhoneList { get; set; }
        public DateTime DateMailPostcardList { get; set; }
        public DateTime DateMailSurveyList { get; set; }
        public string Number { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ProjectQOL ProjectQOL { get; set; }
        public List<Census> Censuses { get; set; }
    }
}
