using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class SongService : CrudService<Song, SongDto>, ISongService
    {
        public SongService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<SongDto> GetById(int id)
        {
            var song = await this._entity
                .Include(song => song.Artist)
                .FirstOrDefaultAsync(song => song.Id == id);

            return this._mapper.Map<SongDto>(song);
        }

        public override async Task<List<SongDto>> GetAll()
        {
            var songs = await this._entity
                .Include(song => song.Artist)
                .ToListAsync();

            return this._mapper.Map<List<SongDto>>(songs);
        }

    }
}
