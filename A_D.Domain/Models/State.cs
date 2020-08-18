using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Consumer> ConsumersMailing { get; set; }
        public List<Consumer> ConsumersPhysical { get; set; }
        public List<ConsumerContact> ConsumerContacts { get; set; }
        public List<ConsumerGuardian> ConsumerGuardians { get; set; }
        public List<Interviewer> Interviewers { get; set; }
        public List<Project> Projects { get; set; }
        public List<County> Counties { get; set; }
        public List<Census> Censuses { get; set; }
    }
}
