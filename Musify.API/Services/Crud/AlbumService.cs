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
            var album = await this._entity
                .Include(album => album.Artist)
                .Include(album => album.AlbumSongs)
                    .ThenInclude(albumsong => albumsong.Song)
                .FirstOrDefaultAsync(album => album.Id == id);

            return this._mapper.Map<AlbumDto>(album);
        }

        public override async Task<List<AlbumDto>> GetAll()
        {
            var albums = await this._entity
                .Include(album => album.Artist)
                .Include(album => album.AlbumSongs)
                    .ThenInclude(albumsong => albumsong.Song)
                .ToListAsync();

            return this._mapper.Map<List<AlbumDto>>(albums);
        }

    }
}
