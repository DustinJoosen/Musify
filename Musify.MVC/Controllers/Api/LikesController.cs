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

        public LikesController(ApplicationDbContext context, ILikeService<Song> songLikeService)
        {
            this._context = context;
            this._songLikeService = songLikeService;
        }


        // POST api/Likes/ToggleUserLikeSong
        [HttpPost("ToggleUserLikeSong/{id}")]
        public async Task<StatusCodeResult> ToggleUserLikeSong(int id)
        {
            int userId = int.Parse(User.Identity.Name);

            await this._songLikeService.Toggle(userId, id);
            return Ok();
        }
    }
}
