using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class Album
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
        public string CoverImage { get; set; } = "notfound.png";

        [Required]
        public string Genre { get; set; }
    }
}
