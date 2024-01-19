using Musify.Infra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.API.Models
{
    public class Album : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
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
