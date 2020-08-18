using System;
using System.Collections.Generic;
using VR.Domain;

namespace A_D.Domain.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public int ProjectNCI_Id { get; set; }
        public DateTime? DateStatusLog { get; set; }
        public DateTime? DateSurvey { get; set; }
        public DateTime? DateVerification { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public ProjectNCI ProjectNCI { get; set; }
        public List<PayRate> PayRates { get; set; }
        public List<Incentive> Incentives { get; set; }
    }
}
