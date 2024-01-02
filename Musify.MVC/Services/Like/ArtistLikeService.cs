using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services
{
    public class ArtistLikeService : LikeService<Artist>
    {
        public ArtistLikeService(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Artist>> GetLikes(int userId)
        {
            return await this._context.UserArtistLikes
                .Where(ual => ual.UserId == userId)
                .Include(ual => ual.Artist)
                .Select(ual => ual.Artist)
                .ToListAsync();
        }

        public override async Task<bool> Like(int userId, int artistId)
        {
            this._context.UserArtistLikes.Add(new UserArtistLike
            {
                UserId = userId,
                ArtistId = artistId
            });

            var result = await this._context.SaveChangesAsync();
            return result >= 1;
        }

        public override async Task<bool> Dislike(int userId, int artistId)
        {
            var like = await this._context.UserArtistLikes
                .FirstOrDefaultAsync(ual => ual.UserId == userId && ual.ArtistId == artistId);

            return await this.Disconnect(like);
        }

        public override bool IsLiked(int userId, int artistId) =>
            this._context.UserArtistLikes.Any(ual => ual.UserId == userId && ual.ArtistId == artistId);
    }
}
