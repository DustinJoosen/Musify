using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class PlaylistQueue
    {
        [Key]
        public int QueueId { get; set; }
        public int? SongId { get; set; }
        public int? AlbumId { get; set; }
        public int? PlaylistId { get; set; }

        public ICollection<Song>? songs { get; set; }
        public ICollection<Playlist>? playlists { get; set; }
        public ICollection<Album>? ablums { get; set; }
    }
}
