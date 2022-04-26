using System.ComponentModel.DataAnnotations;
namespace Farm.Models
{
    public class User
    {
        public int UserId { get; set; } 

        public string Name { get; set; } 

        [Required]
        public string Email { get; set; } 

        [Required]
        public string Password { get; set; } 

        public ICollection<Register> Registers { get; set; } 

    }
}
