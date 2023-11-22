using System.ComponentModel.DataAnnotations;

namespace tamrin.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
