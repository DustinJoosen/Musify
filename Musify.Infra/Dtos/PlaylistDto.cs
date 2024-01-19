using Musify.Infra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.API.Models
{
    public class PlaylistDto : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserDto? User { get; set; }

        public bool IsPublic { get; set; }
    }
}
