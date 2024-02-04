using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public class AlbumSongLinkingService : ILinkingService<AlbumDto, SongDto>
    {
        private ApplicationDbContext _context;

        private IAlbumService _albumService;
        private ISongService _songService;

        public AlbumSongLinkingService(ApplicationDbContext context, IAlbumService albumService, ISongService songService)
        {
            this._context = context;
            this._albumService = albumService;
            this._songService = songService;
        }

        public async Task Link(AlbumDto album, SongDto song) =>
            await this.Link(album.Id, song.Id);
        public async Task Unlink(AlbumDto album, SongDto song) =>
            await this.Unlink(album.Id, song.Id);

        public async Task<bool> Link(int albumId, int songId)
        {
            // Check if the album and song actually exist.
            if (!this._albumService.Exists(albumId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're not paired.
            if (this._context.AlbumSongs.Any(albumsong => albumsong.AlbumId == albumId && albumsong.SongId == songId))
                return false;

            this._context.AlbumSongs.Add(new AlbumSong
            {
                AlbumId = albumId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }

        public async Task<bool> Unlink(int albumId, int songId)
        {
            // Check if the album and song actually exist.
            if (!this._albumService.Exists(albumId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're paired.
            if (!this._context.AlbumSongs.Any(albumsong => albumsong.AlbumId == albumId && albumsong.SongId == songId))
                return false;

            this._context.AlbumSongs.Remove(new AlbumSong
            {
                AlbumId = albumId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }
    }
}
