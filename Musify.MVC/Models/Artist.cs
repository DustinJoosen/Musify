using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Genre { get; set; }

        public string ArtistImage { get; set; } = "notfound.png";

        public virtual ICollection<Song> Songs { get; set; }
    }
}
