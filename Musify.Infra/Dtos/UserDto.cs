using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.Infra.Dtos
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(32)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
