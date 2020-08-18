namespace A_D.Domain.Models
{
    public class Project_Language
    {
        public int Id { get; set; }
        public int Language_Id { get; set; }
        public int Project_Id { get; set; }
        public Language Language { get; set; }
        public Project Project { get; set; }
    }
}
