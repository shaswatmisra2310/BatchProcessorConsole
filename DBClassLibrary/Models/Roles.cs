using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
