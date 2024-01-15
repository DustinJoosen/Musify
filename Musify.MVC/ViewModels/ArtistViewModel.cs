namespace Musify.MVC.ViewModels
{
    public class ArtistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ArtistImage { get; set; }
        public bool Liked { get; set; }
    }
}