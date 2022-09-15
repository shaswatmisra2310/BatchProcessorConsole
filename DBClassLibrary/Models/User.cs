using System.ComponentModel.DataAnnotations;
namespace DBClassLibrary.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public Roles role { get; set; }

        public Analyst analyst { get; set; }
    }
}
