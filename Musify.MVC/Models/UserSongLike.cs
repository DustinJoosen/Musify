using Musify.MVC.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class UserSongLike : IUserLike
    {
        [Key]
        public int SongId { get; set; }
        public Song Song { get; set; }

        [Key]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
