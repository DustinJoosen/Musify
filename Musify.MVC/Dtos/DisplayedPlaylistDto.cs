using Musify.MVC.Models;

using System.Diagnostics;

namespace Musify.MVC.Dtos
{
    [DebuggerDisplay("{Id}: {Title} (@{Username})")]
    public class DisplayedPlaylistDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public bool Liked { get; set; }
        public IEnumerable<Song> Songs { get; internal set; }
    }
}