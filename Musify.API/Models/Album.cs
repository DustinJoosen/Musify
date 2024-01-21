using Musify.Infra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musify.API.Models
{
    public class Album : IIdentifiable
    {
        public Album()
        {
            this.AlbumSongs = new HashSet<AlbumSong>();
            this.CoverImage = "notfound.png";
        }

        [Key]
        public int Id { get; set; }

        public int? ArtistId { get; set; }
        public Artist? Artist { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string CoverImage { get; set; }

        [Required]
        public string Genre { get; set; }

        public virtual ICollection<AlbumSong> AlbumSongs { get; set; }
    }
}
