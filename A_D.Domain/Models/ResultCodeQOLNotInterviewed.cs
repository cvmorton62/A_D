using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ResultCodeQOLNotInterviewed
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool Exclude { get; set; }
        public string Number { get; set; }
        public List<NotInterviewedQOL> NotInterviewedsQOL { get; set; }
        public List<RestartQOL> RestartsQOL { get; set; }
    }
}