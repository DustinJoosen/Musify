using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Data;
using Musify.MVC.Models;
using Musify.MVC.Services;

namespace Musify.MVC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LikesController : ControllerBase
    {
        private ApplicationDbContext _context;
        private ILikeService<Song> _songLikeService;
        private ILikeService<Album> _albumLikeService;
        private ILikeService<Artist> _artistLikeService;

        public LikesController(ApplicationDbContext context, ILikeService<Song> songLikeService,
            ILikeService<Album> albumLikeService, ILikeService<Artist> artistLikeService)
        {
            this._context = context;
            this._songLikeService = songLikeService;
            this._albumLikeService = albumLikeService;
            this._artistLikeService = artistLikeService;
        }


        // POST api/Likes/ToggleUserLikeSong
        [HttpPost("ToggleUserLikeSong/{id}")]
        public async Task<StatusCodeResult> ToggleUserLikeSong(int id)
        {
            int userId = int.Parse(User.Identity.Name);

            await this._songLikeService.Toggle(userId, id);
            return Ok();
        }


        // POST api/Likes/ToggleUserLikeAlbum
        [HttpPost("ToggleUserLikeAlbum/{id}")]
        public async Task<StatusCodeResult> ToggleUserLikeAlbum(int id)
        {
            int userId = int.Parse(User.Identity.Name);

            await this._albumLikeService.Toggle(userId, id);
            return Ok();
        }

        // POST api/Likes/ToggleUserLikeArtist
        [HttpPost("ToggleUserLikeArtist/{id}")]
        public async Task<StatusCodeResult> ToggleUserLikeArtist(int id)
        {
            int userId = int.Parse(User.Identity.Name);

            await this._artistLikeService.Toggle(userId, id);
            return Ok();
        }
    }
}
