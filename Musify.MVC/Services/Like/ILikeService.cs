using Musify.MVC.Models.Interfaces;

namespace Musify.MVC.Services
{
    public interface ILikeService<T>
    {
        public Task<List<T>> GetLikes(int userId);
        public bool IsLiked(int userId, int modelId);
        public Task<bool> Toggle(int userId, int modelId);
        public Task<bool> Like(int userId, int modelId);
        public Task<bool> Dislike(int userId, int modelId);
    }
}
