using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;

namespace Musify.MVC.Controllers
{
    public class DetailsController : Controller
    {
        private ApplicationDbContext _context;
        public DetailsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IActionResult> Artists(int id)
        {
            var artist = await this._context.Artists
                .Include(artist => artist.Songs)
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
                .SingleOrDefaultAsync(album => album.Id == id);

            if (album == null)
                return NotFound();

            return View(album);
        }
    }
}
