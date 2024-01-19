using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class PlaylistService : CrudService<Playlist, PlaylistDto>, IPlaylistService
    {
        public PlaylistService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public bool IsTitleAlreadyUsed(string title) =>
            this._context.Playlists.Any(playlist => playlist.Title == title);

        public override async Task<bool> Create(PlaylistDto dto)
        {
            if (IsTitleAlreadyUsed(dto.Title))
                return false;

            return await base.Create(dto);
        }

        public override async Task<bool> Update(PlaylistDto dto)
        {
            if (this._context.Playlists.Any(playlist => (playlist.Title == dto.Title) && (playlist.Id != dto.Id)))
                return false;

            return await base.Update(dto);
        }
    }
}
