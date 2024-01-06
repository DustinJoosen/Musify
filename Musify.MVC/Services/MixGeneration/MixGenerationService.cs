using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services.MixGeneration
{
    public class MixGenerationService : IMixGenerationService
    {
        private ApplicationDbContext _context;
        private ILikeService<Song> _likeService;
        public MixGenerationService(ApplicationDbContext context, ILikeService<Song> likeService)
        {
            this._context = context;
            this._likeService = likeService;
        }

        public async Task<IEnumerable<Song>> PickLikeBasedSongs(int numberOfSongs, int userId)
        {
            User user = await this.GetAllIncludedUser(userId);
            if (user == null)
                return null;

            var artistSongs = user.UserArtistLikes.SelectMany(ual => ual.Artist.Songs).ToList();
            var albumSongs = user.UserAlbumLikes.SelectMany(ual => ual.Album.AlbumSongs).Select(als => als.Song).ToList();

            return artistSongs
                .Union(albumSongs)
                .DistinctBy(s => s.Id)
                .Where(s => !this._likeService.IsLiked(userId, s.Id))
                .OrderBy(num => Guid.NewGuid())
                .Take(numberOfSongs);
        }

        private async Task<User?> GetAllIncludedUser(int userId)
        {
            return await this._context.Users
               .AsNoTracking()
               .Where(user => user.Id == userId)
               .Include(user => user.UserAlbumLikes)
                   .ThenInclude(ual => ual.Album)
                   .ThenInclude(album => album.AlbumSongs)
                   .ThenInclude(albumSong => albumSong.Song)
               .Include(user => user.UserArtistLikes)
                   .ThenInclude(ual => ual.Artist)
                   .ThenInclude(artist => artist.Songs)
               .SingleOrDefaultAsync();
        }
    }
}
