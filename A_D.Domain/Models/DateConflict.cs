using System;

namespace A_D.Domain.Models
{
    public class DateConflict
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Interviewer Interviewer { get; set; }
    }
}