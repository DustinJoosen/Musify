using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Models;
using System.ComponentModel;

namespace Musify.MVC.Components
{
    public class SongListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ICollection<Song> songs)
        {
            return View(songs);
        }

    }
}
