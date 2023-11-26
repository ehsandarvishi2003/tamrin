using System.ComponentModel.DataAnnotations;

namespace tamrin.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
