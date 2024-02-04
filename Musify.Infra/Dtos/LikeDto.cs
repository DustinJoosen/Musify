using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos
{
    public class LikeDto : IIdentifiable
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserDto? User { get; set; }

        [Required]
        public string EntityType { get; set; }

        [Required]
        public int EntityId { get; set; }
    }
}
