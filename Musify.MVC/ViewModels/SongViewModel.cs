using Musify.MVC.Models;

namespace Musify.MVC.ViewModels
{
    public class SongViewModel
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public string? Title { get; set; }
        public int Duration { get; set; }
        public string? AudioFilePath { get; set; }
        public Album? album { get; set; }
        public bool Liked { get; set; }


        public string FormattedDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }
    }
}
