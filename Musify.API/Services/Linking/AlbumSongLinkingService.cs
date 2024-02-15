using Musify.API.Data;
using Musify.API.Models;
using Musify.API.Services.Linking;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public class AlbumSongLinkingService : 
        BaseLinkingService<AlbumDto, SongDto>, 
        ILinkingService<AlbumDto, SongDto>
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

        /// <summary>
        /// Links album and song
        /// </summary>
        /// <param name="albumId">ID of Album to be linked</param>
        /// <param name="songId">ID of Song to be linked</param>
        /// <returns>Boolean determining success</returns>
        public override async Task<bool> Link(int albumId, int songId)
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

        /// <summary>
        /// Unlinks album and song
        /// </summary>
        /// <param name="albumId">ID of Album to be unlinked</param>
        /// <param name="songId">ID of Song to be unlinked</param>
        /// <returns>Boolean determining success</returns>
        public override async Task<bool> Unlink(int albumId, int songId)
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
