namespace Farm.Models
{
    public class Register
    {
        public int RegisterId { get; set; }

        public DateTime RegisterDate { get; set; }

        public Property Property { get; set; }

        public int PropertyId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
