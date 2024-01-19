using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos
{
    public class CredentialsDto
    {
        [Required, StringLength(32)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
