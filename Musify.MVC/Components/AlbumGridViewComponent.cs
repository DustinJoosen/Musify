using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.ViewModels;

namespace Musify.MVC.Components
{
    public class AlbumGridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ICollection<Album> albums)
        {
            return View(albums
                .Select(album => new AlbumViewModel()
                {
                    Id = album.Id,
                    Title = album.Title,
                    CoverImage = album.CoverImage,
                    ArtistName = album.Artist.Name,
                    Genre = album.Genre,
                    Songs = album.AlbumSongs.Select(album => album.Song),
                    Liked = true
                }).ToList());
        }

    }
}
