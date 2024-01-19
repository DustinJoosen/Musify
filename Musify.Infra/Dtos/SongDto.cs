using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.Infra.Dtos
{
    public class SongDto : IIdentifiable
    {
        public int Id { get; set; }

        [Required]
        public int ArtistId { get; set; }
        public ArtistDto? Artist { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public string FormattedDuration =>
            $"{TimeSpan.FromSeconds(this.Duration).ToString(@"mm\:ss")}";

    }
}
