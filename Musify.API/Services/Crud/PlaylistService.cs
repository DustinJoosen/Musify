using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class PlaylistService : CrudService<Playlist, PlaylistDto>, IPlaylistService
    {
        private IAuthService _authService;
        public PlaylistService(ApplicationDbContext context, IMapper mapper, IAuthService authService) : base(context, mapper)
        {
            this._authService = authService;
        }

        public bool IsTitleAlreadyUsed(string title) =>
            this._entity.Any(playlist => playlist.Title == title);

        public async Task<bool> IsOwnerOfPlaylist(int playlistId, string apiKey)
        {
            var playlist = await this._entity
                .AsNoTracking()
                .SingleOrDefaultAsync(playlist => playlist.Id == playlistId);
            if (playlist == null)
                return false;

            var user = await this._authService.FindUser(apiKey);
            if (user == null)
                return false;

            return user.Id == playlist.UserId;
        }

        public override async Task<PlaylistDto> GetById(int id)
        {
            var playlist = await this._entity
                .Include(playlist => playlist.User)
                .Include(playlist => playlist.PlaylistSongs)
                    .ThenInclude(playlistsong => playlistsong.Song)
                        .ThenInclude(song => song.Artist)
                .SingleOrDefaultAsync(playlist => playlist.Id == id);

            return _mapper.Map<PlaylistDto>(playlist);
        }

        public override async Task<List<PlaylistDto>> GetAll()
        {
            var playlists = await this._entity
                .Include(playlist => playlist.User)
                .Include(playlist => playlist.PlaylistSongs)
                    .ThenInclude(playlistsong => playlistsong.Song)
                        .ThenInclude(song => song.Artist)
                .ToListAsync();

            return _mapper.Map<List<PlaylistDto>>(playlists);
        }

        public override async Task<bool> Create(PlaylistDto dto)
        {
            if (IsTitleAlreadyUsed(dto.Title))
                return false;

            // Check if the userId won't cause foreign key constraint failures.
            if (!this._authService.UserExists(dto.UserId))
                return false;

            return await base.Create(dto);
        }

        public override async Task<bool> Update(PlaylistDto dto)
        {
            if (this._entity.Any(playlist => (playlist.Title == dto.Title) && (playlist.Id != dto.Id)))
                return false;

            // Check if the userId won't cause foreign key constraint failures.
            if (!this._authService.UserExists(dto.UserId))
                return false;

            return await base.Update(dto);
        }

    }
}
