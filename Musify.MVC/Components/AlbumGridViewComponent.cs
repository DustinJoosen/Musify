using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Dtos;
using Musify.MVC.Models;

namespace Musify.MVC.Components
{
    public class AlbumGridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ICollection<Album> albums)
        {
            return View(albums
                .Select(album => new DisplayedAlbumDto()
                {
                    Id = album.Id,
                    Title = album.Title,
                    CoverImage = album.CoverImage,
                    ArtistName = album.Artist.Name,
                    Genre = album.Genre,
                    Liked = true
                }).ToList());
        }

    }
}
