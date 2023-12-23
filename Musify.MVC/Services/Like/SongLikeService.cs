using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services
{
    public class SongLikeService : LikeService<Song>
    {
        public SongLikeService(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Song>> GetLikes(int userId)
        {
            return await this._context.UserSongLikes
                .Where(usl => usl.UserId == userId)
                .Include(usl => usl.Song)
                .Select(usl => usl.Song)
                .ToListAsync();
        }

        public override async Task<bool> Like(int userId, int songId)
        {
            this._context.UserSongLikes.Add(new UserSongLike
            {
                UserId = userId,
                SongId = songId
            });

            var result = await this._context.SaveChangesAsync();
            return result >= 1;
        }

        public override async Task<bool> Dislike(int userId, int songId)
        {
            var like = await this._context.UserSongLikes
                .FirstOrDefaultAsync(usl => usl.UserId == userId && usl.SongId == songId);

            return await this.Disconnect(like);
        }

        public override bool IsLiked(int userId, int songId) =>
            this._context.UserSongLikes.Any(usl => usl.UserId == userId && usl.SongId == songId);
    }
}
