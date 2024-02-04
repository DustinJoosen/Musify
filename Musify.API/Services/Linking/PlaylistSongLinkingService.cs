using Musify.API.Data;
using Musify.API.Migrations;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public class PlaylistSongLinkingService : ILinkingService<PlaylistDto, SongDto>
    {
        private ApplicationDbContext _context;

        private IPlaylistService _playlistService;
        private ISongService _songService;

        public PlaylistSongLinkingService(ApplicationDbContext context, IPlaylistService playlistService, 
            ISongService songService)
        {
            this._context = context;
            this._playlistService = playlistService;
            this._songService = songService;
        }

        public async Task Link(PlaylistDto playlist, SongDto song) =>
            await this.Link(playlist.Id, song.Id);
        public async Task Unlink(PlaylistDto playlist, SongDto song) =>
            await this.Unlink(playlist.Id, song.Id);

        public async Task<bool> Link(int playlistId, int songId)
        {
            // Check if the playlist and song actually exist.
            if (!this._playlistService.Exists(playlistId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're not paired.
            if (this._context.PlaylistSongs.Any(playlistsong => playlistsong.PlaylistId == playlistId && playlistsong.SongId == songId))
                return false;

            this._context.PlaylistSongs.Add(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }

        public async Task<bool> Unlink(int playlistId, int songId)
        {
            // Check if the playlist and song actually exist.
            if (!this._playlistService.Exists(playlistId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're paired.
            if (!this._context.PlaylistSongs.Any(playlistsong => playlistsong.PlaylistId == playlistId && playlistsong.SongId == songId))
                return false;

            this._context.PlaylistSongs.Remove(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }
    }
}
