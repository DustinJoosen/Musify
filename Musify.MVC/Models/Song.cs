using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.MVC.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public virtual ICollection<AlbumSong> AlbumSongs { get; set; }
        public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; }

    }
}
