using Musify.Infra.Dtos;

namespace Musify.API.Services.Likes
{
    public interface ILikesService
    {
        public Task<List<LikeDto>> FindLikes(int userId);
        public Task<List<LikeDto>> FindLikes(int userId, string entityType);
        public Task<bool> IsLiked(LikeDto like);
        public Task<bool> Like(LikeDto like);
        public Task<bool> Dislike(LikeDto like);

    }
}