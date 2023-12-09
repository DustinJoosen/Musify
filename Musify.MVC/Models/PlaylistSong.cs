using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class PlaylistSong
    {
        [Key]
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        [Key]
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
