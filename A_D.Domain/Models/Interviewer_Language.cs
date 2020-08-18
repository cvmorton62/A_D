namespace A_D.Domain.Models
{
    public class Interviewer_Language
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int Language_Id { get; set; }
        public Interviewer Interviewer { get; set; }
        public Language Language { get; set; }
    }
}
