using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;
using Musify.MVC.Services;

namespace Musify.MVC.Controllers
{
    [Authorize]
    public class DetailsController : Controller
    {
        private ApplicationDbContext _context;
        private ILikeService<Album> _albumLikeService;

        public DetailsController(ApplicationDbContext context, ILikeService<Album> albumLikeService)
        {
            this._context = context;
            this._albumLikeService = albumLikeService;
        }

        public async Task<IActionResult> Artists(int id)
        {
            var artist = await this._context.Artists
                .Include(artist => artist.Songs)
                    .ThenInclude(song => song.UserSongLikes)
                .SingleOrDefaultAsync(artist => artist.Id == id);

            if (artist == null)
                return NotFound();

            return View(artist);
        }

        public async Task<IActionResult> Albums(int id)
        {
            var album = await this._context.Album
                .Include(album => album.Artist)
                .Include(album => album.AlbumSongs)
                    .ThenInclude(albumsong => albumsong.Song)
                        .ThenInclude(song => song.UserSongLikes)
                .SingleOrDefaultAsync(album => album.Id == id);

            if (album == null)
                return NotFound();

            int userId = int.Parse(User.Identity.Name);
            ViewData["Liked"] = this._albumLikeService.IsLiked(userId, id);

            return View(album);
        }
    }
}
