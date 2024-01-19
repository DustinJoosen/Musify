using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class AlbumService : CrudService<Album, AlbumDto>, IAlbumService
    {
        public AlbumService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<AlbumDto> GetById(int id)
        {
            var model = await this._entity
                .Include(album => album.Artist)
                .FirstOrDefaultAsync(album => album.Id == id);

            return this._mapper.Map<AlbumDto>(model);
        }
    }
}
