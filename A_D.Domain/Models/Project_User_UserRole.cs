namespace A_D.Domain.Models
{
    public class Project_User_UserRole
    {
        public int Id { get; set; }
        public int Project_Id { get; set; }
        public int User_Id { get; set; }
        public int UserRole_Id { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
        public UserRole UserRole { get; set; }
    }
}
