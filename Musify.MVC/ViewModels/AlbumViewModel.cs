using Musify.MVC.Models;

namespace Musify.MVC.ViewModels
{
    public class AlbumViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public bool Liked { get; set; }
        public IEnumerable<Song> Songs { get; internal set; }
    }
}
