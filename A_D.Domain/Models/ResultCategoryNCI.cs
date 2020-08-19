using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ResultCategoryNCI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StatusLogNCI> StatusLogsNCI { get; set; }
        public List<ResultNCI> ResultsNCI { get; set; }
        public List<Sample_ResultCategoryNCI> Samples_ResultCategoriesNCI { get; set; }
    }
}