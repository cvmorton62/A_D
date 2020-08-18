using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ProjectNCI
    {
        public int Id { get; set; }
        public int? NotifyingParty_Id { get; set; }
        public int Project_Id { get; set; }
        public bool SelfDirectedSupports { get; set; }
        public bool StateSpecificQuestions { get; set; }
        public bool WrittenConsent { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public NotifyingParty NotifyingParty { get; set; }
        public Project Project { get; set; }
        public List<Sample> Samples { get; set; }
    }
}
