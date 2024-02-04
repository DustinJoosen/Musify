using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Musify.API.Middleware;
using Musify.API.Migrations;
using Musify.API.Models;
using Musify.API.Services;
using Musify.API.Services.Likes;
using Musify.Infra.Dtos;

namespace Musify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private ILikesService _likeService;
        private IAuthService _authService;
        public LikesController(ILikesService likeService, IAuthService authService)
        {
            this._likeService = likeService;
            this._authService = authService;
        }

        [HttpGet]
        [ApiKeyAuthorized(Permission = Infra.ApiKeyPermissions.Read)]
        public async Task<IActionResult> FindLikes(int userId, string? entityType=null)
        {
            if (entityType != null && !this.IsTargetTypeValid(entityType))
                return BadRequest($"EntityType is not valid. Options: {string.Join(", ", _validTargets)}");

            if (!this._authService.UserExists(userId))
                return BadRequest("UserId is not valid");

            // Ensure only the owner of the like can see their own data.
            if (userId != (await this._authService.FindUser(Request.Headers["ApiKey"])).Id)
                return StatusCode(403, "ApiKey does not match given UserId");

            var likes = entityType == null
                ? await this._likeService.FindLikes(userId)
                : await this._likeService.FindLikes(userId, entityType);

            return Ok(likes);
        }

        [HttpGet("IsLiked")]
        [ApiKeyAuthorized(Permission = Infra.ApiKeyPermissions.Read)]
        public async Task<IActionResult> IsLiked(int userId, string entityType, int entityId)
        {
            // Ensure only the owner of the like can see their own data.
            if (userId != (await this._authService.FindUser(Request.Headers["ApiKey"])).Id)
                return Forbid("ApiKey does not match given UserId");

            var succeeded = await this._likeService.IsLiked(new LikeDto
            {
                UserId = userId,
                EntityType = entityType,
                EntityId = entityId
            });

            return Ok(succeeded);
        }

        [HttpPost("Like")]
        [ApiKeyAuthorized(Permission = Infra.ApiKeyPermissions.Read)]
        public async Task<IActionResult> Like(LikeDto like)
        {
            if (!this.IsTargetTypeValid(like.EntityType))
                return BadRequest($"EntityType is not valid. Options: {string.Join(", ", _validTargets)}");

            if (!this._authService.UserExists(like.UserId))
                return BadRequest("UserId is not valid");

            // Ensure only the owner of the like can like.
            if (like.UserId != (await this._authService.FindUser(Request.Headers["ApiKey"])).Id)
                return Forbid("ApiKey does not match given UserId");

            if (await this._likeService.IsLiked(like))
                return BadRequest("User already likes this entity");

            var succeeded = await this._likeService.Like(like);
            if (!succeeded)
                return BadRequest("Can't like this entity");

            return Ok(like);
        }

        [HttpPost("Dislike")]
        [ApiKeyAuthorized(Permission = Infra.ApiKeyPermissions.Read)]
        public async Task<IActionResult> Disike(LikeDto like)
        {
            if (!this.IsTargetTypeValid(like.EntityType))
                return BadRequest($"EntityType is not valid. Options: {string.Join(", ", _validTargets)}");

            if (!this._authService.UserExists(like.UserId))
                return BadRequest("UserId is not valid");

            // Ensure only the owner of the like can dislike
            if (like.UserId != (await this._authService.FindUser(Request.Headers["ApiKey"])).Id)
                return Forbid("ApiKey does not match given UserId");

            if (!await this._likeService.IsLiked(like))
                return BadRequest("User doesn't likes this entity");

            var succeeded = await this._likeService.Dislike(like);
            if (!succeeded)
                return BadRequest("Can't dislike this entity");

            return Ok(like);
        }

        private static readonly string[] _validTargets = ["album", "song", "artist", "playlist"];
        private bool IsTargetTypeValid(string target) =>
            _validTargets.Contains(target);
    }
}
