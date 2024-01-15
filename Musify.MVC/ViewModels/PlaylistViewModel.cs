using Musify.MVC.Models;

using System.Diagnostics;

namespace Musify.MVC.ViewModels
{
    [DebuggerDisplay("{Id}: {Title} (@{Username})")]
    public class PlaylistViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public bool Liked { get; set; }
        public IEnumerable<Song> Songs { get; internal set; }
    }
}