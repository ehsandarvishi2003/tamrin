using System.ComponentModel.DataAnnotations;

namespace tamrin.DTOs
{
    public class UserRegisterDTO
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Name")] // this Used for label of Name Input in RegisterView
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwoords not same")]
        public string RepeatPassword { get; set; }
    }
}
