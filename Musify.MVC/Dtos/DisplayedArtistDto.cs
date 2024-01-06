namespace Musify.MVC.Dtos
{
    public class DisplayedArtistDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ArtistImage { get; set; }
        public bool Liked { get; set; }
    }
}