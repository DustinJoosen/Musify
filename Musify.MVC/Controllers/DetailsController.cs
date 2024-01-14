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
        private ILikeService<Artist> _artistLikeService;
        private ILikeService<Song> _songLikeService;

        public DetailsController(ApplicationDbContext context, ILikeService<Album> albumLikeService,
            ILikeService<Artist> artistLikeService, ILikeService<Song> songLikeService)
        {
            this._context = context;
            this._albumLikeService = albumLikeService;
            this._artistLikeService = artistLikeService;
            this._songLikeService = songLikeService;
        }

        public async Task<IActionResult> Artists(int id)
        {
            var artist = await this._context.Artists
                .Include(artist => artist.Songs)
                    .ThenInclude(song => song.UserSongLikes)
                .SingleOrDefaultAsync(artist => artist.Id == id);

            if (artist == null)
                return NotFound();

            int userId = int.Parse(User.Identity.Name);
            ViewData["Liked"] = this._artistLikeService.IsLiked(userId, id);

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

        public async Task<IActionResult> Songs(int id)
        {
            var song = await this._context.Songs
                .Include(song => song.Artist)
                .Include(song => song.AlbumSongs)
                .Include(song => song.UserSongLikes)
                .SingleOrDefaultAsync(album => album.Id == id);

            if (song == null)
                return NotFound();

            int userId = int.Parse(User.Identity.Name);
            ViewData["Liked"] = this._songLikeService.IsLiked(userId, id);

            return View(song);
        }
    }
}
