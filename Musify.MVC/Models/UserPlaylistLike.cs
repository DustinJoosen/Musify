using Musify.MVC.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class UserPlaylistLike : IUserLike
    {
        [Key]
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        [Key]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
