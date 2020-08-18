using System;

namespace A_D.Domain.Models
{
    public class ConsumerNote
    {
        public int Id { get; set; }
        public int Consumer_Id { get; set; }
        public int User_Id { get; set; }
        public string Caller { get; set; }
        public string Comment { get; set; }
        public DateTime? DateInterviewerNotified { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Consumer Consumer { get; set; }
        public User User { get; set; }
    }
}
