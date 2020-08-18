using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public bool Inactive { get; set; }
        public string Initials { get; set; }
        public string Name { get; set; }
        public string WinUserId { get; set; }
        public List<ConsumerNote> ConsumerNotes { get; set; }
        public List<DeviceNote> DeviceNotes { get; set; }
        public List<FacilityNote> FacilityNotes { get; set; }
        public List<InterviewerNote> InterviewerNotes { get; set; }
        public List<Project_User_UserRole> Projects_Users_UserRoles { get; set; }
        public List<DeviceDeployment> DeviceDeployments { get; set; }
    }
}
