using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services
{
    public class PlaylistLikeService : LikeService<Playlist>
    {
        public PlaylistLikeService(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Playlist>> GetLikes(int userId)
        {
            return await this._context.UserPlaylistLikes
                .Where(usl => usl.UserId == userId)
                .Include(usl => usl.Playlist)
                .Select(usl => usl.Playlist)
                .ToListAsync();
        }

        public override async Task<bool> Like(int userId, int playlistId)
        {
            this._context.UserPlaylistLikes.Add(new UserPlaylistLike
            {
                UserId = userId,
                PlaylistId = playlistId
            });

            var result = await this._context.SaveChangesAsync();
            return result >= 1;
        }

        public override async Task<bool> Dislike(int userId, int playlistId)
        {
            var like = await this._context.UserPlaylistLikes
                .FirstOrDefaultAsync(usl => usl.UserId == userId && usl.PlaylistId == playlistId);

            return await this.Disconnect(like);
        }

        public override bool IsLiked(int userId, int playlistId) =>
            this._context.UserPlaylistLikes.Any(usl => usl.UserId == userId && usl.PlaylistId == playlistId);
    }
}
