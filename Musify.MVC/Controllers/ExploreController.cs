using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Musify.MVC.Dtos;

namespace Musify.MVC.Controllers
{
    public class ExploreController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(ExploreDto exploreDto)
        {
            ViewData["SearchTypes"] = new SelectList(Enum.GetNames<SearchType>(), exploreDto?.SearchType);
            return View(exploreDto);
        }
    }
}
