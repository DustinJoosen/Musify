using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services
{
    public class AlbumLikeService : LikeService<Album>
    {
        public AlbumLikeService(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Album>> GetLikes(int userId)
        {
            return await this._context.UserAlbumLikes
                .Where(ual => ual.UserId == userId)
                .Include(ual => ual.Album)
                .Select(ual => ual.Album)
                .ToListAsync();
        }

        public override async Task<bool> Like(int userId, int albumId)
        {
            this._context.UserAlbumLikes.Add(new UserAlbumLike
            {
                UserId = userId,
                AlbumId = albumId
            });

            var result = await this._context.SaveChangesAsync();
            return result >= 1;
        }

        public override async Task<bool> Dislike(int userId, int albumId)
        {
            var like = await this._context.UserAlbumLikes
                .FirstOrDefaultAsync(ual => ual.UserId == userId && ual.AlbumId == albumId);

            return await this.Disconnect(like);
        }

        public override bool IsLiked(int userId, int albumId) =>
            this._context.UserAlbumLikes.Any(ual => ual.UserId == userId && ual.AlbumId == albumId);
    }
}
