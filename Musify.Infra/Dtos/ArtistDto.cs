using System.ComponentModel.DataAnnotations;

namespace Musify.Infra.Dtos
{
    public class ArtistDto : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Genre { get; set; }
        public string ArtistImage { get; set; } = "notfound.png";
    }
}
