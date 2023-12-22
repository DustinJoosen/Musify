namespace Musify.MVC.Dtos
{
    public class DisplayedAlbumDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public bool Liked { get; set; }
    }
}
