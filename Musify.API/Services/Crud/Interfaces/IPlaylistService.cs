using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IPlaylistService : ICrudService<Playlist, PlaylistDto>
    {
        public bool IsTitleAlreadyUsed(string title);
    }
}
