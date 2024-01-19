using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos
{
    public class AlbumDto : IIdentifiable
    {
        public int Id { get; set; }

        public int ArtistId { get; set; }
        public ArtistDto? Artist { get; set; }

        [Required]
        public string Title { get; set; }

        public string CoverImage { get; set; } = "notfound.png";

        [Required]
        public string Genre { get; set; }
    }
}
