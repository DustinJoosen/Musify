using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos
{
    public class RegisterDto
    {
        [Required, StringLength(32)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
