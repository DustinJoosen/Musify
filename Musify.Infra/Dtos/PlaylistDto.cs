using Musify.Infra;
using Musify.Infra.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Musify.Infra.Dtos
{
    public class PlaylistDto : IIdentifiable
    {
        public PlaylistDto()
        {
            this.Songs = new HashSet<SongDto>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserDto? User { get; set; }

        public bool IsPublic { get; set; }

        public virtual ICollection<SongDto> Songs { get; set; }
    }
}
