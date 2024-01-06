using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.MVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(32)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; } = DateTime.Now;

        [Required]
        public string Password { get; set; }

        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<UserSongLike> UserSongLikes { get; set; }
        public ICollection<UserAlbumLike> UserAlbumLikes { get; set; }
        public ICollection<UserArtistLike> UserArtistLikes { get; set; }
        public ICollection<UserPlaylistLike> UserPlaylistLikes { get; set; }
    }
}
