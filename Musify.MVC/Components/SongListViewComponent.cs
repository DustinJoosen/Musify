using Microsoft.AspNetCore.Mvc;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.Services;
using System.ComponentModel;

namespace Musify.MVC.Components
{
    public class SongListViewComponent : ViewComponent
    {
        private ILikeService<Song> _service;
        public SongListViewComponent(ILikeService<Song> service)
        {
            this._service = service;
        }


        public async Task<IViewComponentResult> InvokeAsync(ICollection<Song> songs)
        {
            int userId = int.Parse(User?.Identity?.Name ?? "0");

            List<DisplayedSongDto> processed = songs
                .Select(song => new DisplayedSongDto()
                {
                    Id = song.Id,
                    SongTitle = song.Title,
                    SongDuration = song.FormattedDuration,
                    Liked = this._service.IsLiked(userId, song.Id)
                }).ToList();

            return View(processed);
        }

    }
}
