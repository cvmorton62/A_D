using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project_User_UserRole> Projects_Users_UserRoles { get; set; }
    }
}
