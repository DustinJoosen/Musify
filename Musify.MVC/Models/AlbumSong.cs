using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class AlbumSong
    {
        [Key]
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        [Key]
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
