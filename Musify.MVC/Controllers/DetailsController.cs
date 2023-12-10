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
    }
}
