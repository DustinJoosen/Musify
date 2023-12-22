using Musify.MVC.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class UserAlbumLike : IUserLike
    {
        [Key]
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        [Key]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
