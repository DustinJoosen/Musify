﻿
using Musify.MVC.Data;
using Musify.MVC.Models.Interfaces;

namespace Musify.MVC.Services
{
    public abstract class LikeService<T> : ILikeService<T>
    {
        protected ApplicationDbContext _context;
        public LikeService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public abstract Task<List<T>> GetLikes(int userId);
        public abstract bool IsLiked(int userId, int modelId);

        public abstract Task<bool> Like(int userId, int modelId);
        public abstract Task<bool> Dislike(int userId, int modelId);

        public async Task<bool> Toggle(int userId, int modelId)
        {
            return (this.IsLiked(userId, modelId))
                ? this.Dislike(userId, modelId).Result
                : this.Like(userId, modelId).Result;
        }

        protected async Task<bool> Disconnect(IUserLike like)
        {
            if (like == null)
                return false;

            this._context.Remove(like);

            var result = await this._context.SaveChangesAsync();
            return result >= 1;
        }
    }
}