using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Dtos
{
    public class AuthDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }

    }
}
