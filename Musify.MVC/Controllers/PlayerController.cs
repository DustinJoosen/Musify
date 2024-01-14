using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.ViewModels;

namespace Musify.MVC.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id, int PLId, int AlbumId)
        {
            if (PLId != 0)
            {
                // Retrieve playlist information
                var viewModel = await _context.Playlists
           .Where(p => p.Id == PLId)
           .Select(p => new PlayListSongViewModel
           {
               PlaylistId = p.Id,

               songs = p.PlaylistSongs!.Select(ps => new SongViewModel
               {
                   SongId = ps.Song!.Id,
                   ArtistId = ps.Song.ArtistId,
                   ArtistName = ps.Song.Artist.Name,
                   Title = ps.Song.Title,
                   Duration = ps.Song.Duration
               }).ToList()
           })
           .FirstOrDefaultAsync();

                if (viewModel == null)
                {
                    return NotFound();
                }
                var albums = await _context.Album.ToListAsync();
                var songs = await _context.Songs.ToListAsync();
                var playlists = await _context.Playlists.ToListAsync();

                ViewBag.albums = albums;
                ViewBag.songs = songs;
                ViewBag.playlists = playlists;
                ViewBag.SongId = id;
                return View(viewModel);
            }
            else if (AlbumId != 0)
            {
                var viewModel = await _context.Album
           .Where(p => p.Id == AlbumId)
           .Select(p => new PlayListSongViewModel
           {
               PlaylistId = 0,
               PlaylistName = "Album",
               songs = p.AlbumSongs!.Select(ps => new SongViewModel
               {
                   SongId = ps.Song!.Id,
                   ArtistId = ps.Song.ArtistId,
                   ArtistName = ps.Song.Artist.Name,
                   Title = ps.Song.Title,
                   Duration = ps.Song.Duration
               }).ToList()
           })
           .FirstOrDefaultAsync();
                var albums = await _context.Album.ToListAsync();
                var songs = await _context.Songs.ToListAsync();
                var playlists = await _context.Playlists.ToListAsync();

                ViewBag.albums = albums;
                ViewBag.songs = songs;
                ViewBag.playlists = playlists;
                ViewBag.SongId = 1;
                return View(viewModel);
            }
            else
            {
                PlayListSongViewModel playlistSong = new PlayListSongViewModel();
                var song = await _context.Songs
                                .FirstOrDefaultAsync(m => m.Id == id);
                if (song != null)
                {
                    playlistSong = new PlayListSongViewModel
                    {
                        PlaylistId = 0,
                        PlaylistName = "Random",
                        songs = new List<ViewModels.SongViewModel>
                    {
                        new ViewModels.SongViewModel
                        {
                             SongId = song.Id,
                   ArtistId = song.ArtistId,
                   ArtistName = song.Artist.Name,
                   Title = song.Title,
                   Duration = song.Duration
                        }
                    }
                    };
                }
                var albums = await _context.Album.ToListAsync();
                var songs = await _context.Songs.ToListAsync();
                var playlists = await _context.Playlists.ToListAsync();

                ViewBag.albums = albums;
                ViewBag.songs = songs;
                ViewBag.playlists = playlists;
                ViewBag.SongId = id;
                return View(playlistSong);
            }
        }


    }
}
