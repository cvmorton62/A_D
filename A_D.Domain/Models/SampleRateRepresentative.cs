using System;

namespace A_D.Domain.Models
{
    public class SampleRateRepresentative
    {
        public int Id { get; set; }
        public int ProjectQOL_Id { get; set; }
        public int SampleCount { get; set; }
        public int SurveyGoal { get; set; }
        public ProjectQOL ProjectQOL { get; set; }
    }
}
