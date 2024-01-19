using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IAlbumService : ICrudService<Album, AlbumDto>
    {
    }
}
