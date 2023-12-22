namespace Musify.MVC.Dtos
{
    public class DisplayedSongDto
    {
        public int Id { get; set; }
        public bool Liked { get; set; }
        public string SongTitle { get; set; }
        public string SongDuration { get; set; }
        public string Artist { get; set; }
    }
}
