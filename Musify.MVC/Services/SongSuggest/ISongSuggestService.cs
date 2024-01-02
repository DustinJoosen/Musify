using Musify.MVC.Models;

namespace Musify.MVC.Services.SongSuggest
{
    public interface ISongSuggestService
    {
        public IEnumerable<Song> PickSuggestedSongs(int numberOfSongs, IEnumerable<Song> basedOn);
    }
}
