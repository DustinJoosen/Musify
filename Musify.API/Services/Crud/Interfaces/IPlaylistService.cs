using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IPlaylistService : ICrudService<Playlist, PlaylistDto>
    {
        /// <summary>
        /// Checks wether a title is already in use
        /// </summary>
        /// <param name="title">Title to be checked</param>
        /// <returns>A boolean determining wether the title is already in use</returns>
        public bool IsTitleAlreadyUsed(string title);

        /// <summary>
        /// Checks wether the user connected to a apiKey is the owner of a playlist.
        /// </summary>
        /// <param name="playlistId">Id of the playlist</param>
        /// <param name="apiKey">ApiKey to check permissions from</param>
        /// <returns>A boolean determining wether the apiKey can access the playlist as an owner</returns>
        public Task<bool> IsOwnerOfPlaylist(int playlistId, string apiKey);
    }
}
