namespace Musify.MVC.Models.ViewModels
{
    public class SongViewModel
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public string? Title { get; set; }
        public int? Duration { get; set; }
        public string? AudioFilePath { get; set; }
        public Album? album { get; set; }
    }
}
