using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Data;
using Musify.MVC.Models;
using System.Diagnostics;

namespace Musify.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users.FindAsync(userId);

            ViewData["username"] = user.Username;

            return View();
        }

    }
}
