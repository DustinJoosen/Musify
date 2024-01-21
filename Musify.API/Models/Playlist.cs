using Musify.Infra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.API.Models
{
    public class Playlist : IIdentifiable
    {
        public Playlist()
        {
            this.PlaylistSongs = new HashSet<PlaylistSong>();    
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public bool IsPublic { get; set; }

        public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; }

    }
}
