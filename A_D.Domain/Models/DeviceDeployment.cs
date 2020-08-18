using System;

namespace A_D.Domain.Models
{
    public class DeviceDeployment
    {
        public int Id { get; set; }
        public int Device_Id { get; set; }
        public int? Interviewer_Id { get; set; }
        public int? User_Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime DateReturn { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Device Device { get; set; }
        public Interviewer Interviewer { get; set; }
        public User User { get; set; }
    }
}
