using Musify.Infra.Dtos;

namespace Musify.API.Services.Likes
{
    public interface ILikesService
    {
        /// <summary>
        /// Returns all likes of given user
        /// </summary>
        /// <param name="userId">Id of user to check.</param>
        /// <returns>List of <typeparamref name="LikeDto"/>'s</returns>
        public Task<List<LikeDto>> FindLikes(int userId);

        /// <summary>
        /// Returns all likes of given user on a specific entity
        /// </summary>
        /// <param name="userId">Id of user to check.</param>
        /// <param name="entityType">Type to be searched.</param>
        /// <returns>List of <typeparamref name="LikeDto"/>'s</returns>
        public Task<List<LikeDto>> FindLikes(int userId, string entityType);

        /// <summary>
        /// Check wether a Like object exists.
        /// </summary>
        /// <param name="like">Like object to be checked</param>
        /// <returns>Boolean determining wether the like object exists</returns>
        public Task<bool> IsLiked(LikeDto like);

        /// <summary>
        /// Creates a like object
        /// </summary>
        /// <param name="like">Like object to be created</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Like(LikeDto like);

        /// <summary>
        /// Removes a like object
        /// </summary>
        /// <param name="like">Like object to be removed</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Dislike(LikeDto like);

    }
}