using System;

namespace A_D.Domain.Models
{
    public class DeviceNote
    {
        public int Id { get; set; }
        public int Device_Id { get; set; }
        public int User_Id { get; set; }
        public string Note { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Device Device { get; set; }
        public User User { get; set; }
    }
}
