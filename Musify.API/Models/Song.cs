using Musify.Infra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.API.Models
{
    public class Song : IIdentifiable
    {
        public Song()
        {
            this.ReleaseDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public int? ArtistId { get; set; }
        public Artist? Artist { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
