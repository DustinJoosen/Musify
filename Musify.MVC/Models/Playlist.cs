using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Display (Name = "Created by user")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int Timestamp { get; set; }

        [Display (Name = "Is public")]
        public bool IsPublic { get; set; } = false;
    }
}
