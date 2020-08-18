using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ResultCodeQOLIncomplete
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Number { get; set; }
        public List<SurveyQOL> SurveysQOL { get; set; }
        public List<RestartQOL> RestartsQOL { get; set; }
    }
}