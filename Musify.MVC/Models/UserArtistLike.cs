using Musify.MVC.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class UserArtistLike : IUserLike
    {
        [Key]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [Key]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
