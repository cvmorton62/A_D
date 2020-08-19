using System;

namespace A_D.Domain.Models
{
    public class StatusLogNCI
    {
        public int Id { get; set; }
        public int Consumer_Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int RefusalReasonNCI_Id { get; set; }
        public int ResultCategoryNCI_Id { get; set; }
        public DateTime Date { get; set; }
        public bool Exclude { get; set; }
        public string InterviewNumber { get; set; }
        public string InterviewTime { get; set; }
        public bool LastResult { get; set; }
        public string RefusalReasonOther { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime Time { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Consumer Consumer { get; set; }
        public Interviewer Interviewer { get; set; }
        public ResultCategoryNCI ResultCategoryNCI { get; set; }
        public RefusalReasonNCI RefusalReasonNCI { get; set; }
    }
}
