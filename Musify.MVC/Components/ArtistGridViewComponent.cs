using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Dtos;
using Musify.MVC.Models;

namespace Musify.MVC.Components
{
    public class ArtistGridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ICollection<Artist> artists)
        {
            return View(artists
                .Select(artist => new DisplayedArtistDto()
                {
                    Id = artist.Id,
                    Name = artist.Name,
                    Genre = artist.Genre,
                    ArtistImage = artist.ArtistImage,
                    Liked = true
                }).ToList());
        }

    }
}
