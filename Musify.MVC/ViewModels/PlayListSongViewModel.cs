﻿namespace Musify.MVC.ViewModels
{
    public class PlayListSongViewModel
    {
        public int PlaylistId { get; set; }
        public string? PlaylistName { get; set; }
        public ICollection<SongViewModel>? songs { get; set; }
    }
}
