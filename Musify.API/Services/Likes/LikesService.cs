using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Likes
{
    public class LikesService : ILikesService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public LikesService(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        /// <summary>
        /// Check wether a Like object exists.
        /// </summary>
        /// <param name="like">Like object to be checked</param>
        /// <returns>Boolean determining wether the like object exists</returns>
        public async Task<bool> IsLiked(LikeDto like)
        {
            return await this._context.Likes.AnyAsync(l =>
                l.UserId == like.UserId &&
                l.EntityId == like.EntityId &&
                l.EntityType == like.EntityType);
        }

        /// <summary>
        /// Creates a like object
        /// </summary>
        /// <param name="like">Like object to be created</param>
        /// <returns>Boolean determining success</returns>
        public async Task<bool> Like(LikeDto like)
        {
            if (await this.IsLiked(like))
                return false;

            this._context.Add(new Like
            {
                UserId = like.UserId,
                EntityId = like.EntityId,
                EntityType = like.EntityType
            });

            int rows = await this._context.SaveChangesAsync();
            return rows == 1;
        }

        /// <summary>
        /// Removes a like object
        /// </summary>
        /// <param name="likeDto">Like object to be removed</param>
        /// <returns>Boolean determining success</returns>
        public async Task<bool> Dislike(LikeDto likeDto)
        {
            if (!await this.IsLiked(likeDto))
                return false;

            var like = await this._context.Likes
                .SingleOrDefaultAsync(l => l.UserId == likeDto.UserId && l.EntityId == likeDto.EntityId && l.EntityType == likeDto.EntityType);

            if (like == null)
                return false;

            this._context.Remove(like);

            int rows = await this._context.SaveChangesAsync();
            return rows == 1;
        }

        /// <summary>
        /// Returns all likes of given user
        /// </summary>
        /// <param name="userId">Id of user to check.</param>
        /// <returns>List of <typeparamref name="LikeDto"/>'s</returns>
        public async Task<List<LikeDto>> FindLikes(int userId)
        {
            var likes = await this._context.Likes
                .Where(like => like.UserId == userId)
                .ToListAsync();

            if (likes == null || !likes.Any())
                return [];

            return this._mapper.Map<List<LikeDto>>(likes);
        }

        /// <summary>
        /// Returns all likes of given user on a specific entity
        /// </summary>
        /// <param name="userId">Id of user to check.</param>
        /// <param name="entityType">Type to be searched.</param>
        /// <returns>List of <typeparamref name="LikeDto"/>'s</returns>
        public async Task<List<LikeDto>> FindLikes(int userId, string entityType)
        {
            var likes = await this._context.Likes
                .Where(like => like.UserId == userId)
                .Where(like => like.EntityType.Equals(entityType))
                .ToListAsync();

            return this._mapper.Map<List<LikeDto>>(likes);
        }
    }
}
