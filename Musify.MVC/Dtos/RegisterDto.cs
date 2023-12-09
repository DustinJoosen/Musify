using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Password again. For confirmation")]
        public string PasswordConfirmation { get; set; }
    }
}
