using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface ISongService : ICrudService<Song, SongDto>
    {
    }
}
