using Musify.Infra;
using System.ComponentModel.DataAnnotations;

namespace Musify.API.Models
{
    public class Artist : IIdentifiable
    {
        public Artist()
        {
            this.ArtistImage = "notfound.png";
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Genre { get; set; }

        public string ArtistImage { get; set; }
    }
}
