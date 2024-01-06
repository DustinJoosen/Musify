using Musify.MVC.Models;

namespace Musify.MVC.Services.MixGeneration
{
    public interface IMixGenerationService
    {
        public Task<IEnumerable<Song>> PickLikeBasedSongs(int numberOfSongs, int userId);
    }
}