using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Controllers.Api;
using Musify.MVC.Data;
using Musify.MVC.Models;
using Musify.MVC.Services.MixGeneration;
using Musify.MVC.Services.SongSuggest;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Musify.MVC.Controllers
{
    [Authorize]
    public class LibraryController : Controller
    {
        private ApplicationDbContext _context;
        private ISongSuggestService _songSuggestService;
        private IMixGenerationService _mixGenerationService;

        private const string _mixCookieName = "GeneratedMixList";

        public LibraryController(ApplicationDbContext context, ISongSuggestService songSuggestService,
            IMixGenerationService mixGenerationService)
        {
            this._context = context;
            this._songSuggestService = songSuggestService;
            this._mixGenerationService = mixGenerationService;
        }

        public async Task<IActionResult> Index()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users.FindAsync(userId);

            return View(user);
        }

        public async Task<IActionResult> Mix()
        {
            var cookie = Request.Cookies[_mixCookieName];
            if (cookie == null)
                return View(new List<Song>());

            var songIds = JsonSerializer.Deserialize<List<int>>(cookie);

            var songs = await this._context.Songs
                .Where(song => songIds.Contains(song.Id))
                .ToListAsync();

            return View(songs);
        }

        public async Task<IActionResult> MyPlaylists()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users
                .Include(user => user.Playlists)
                    .ThenInclude(playlist => playlist.PlaylistSongs)
                .FirstOrDefaultAsync(user => user.Id == userId);

            var playlists = user.Playlists.ToList();
            return View(playlists);
        }

        [Route("Library/Liked/Songs")]
        public async Task<IActionResult> LikedSongs()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users
                .Include(user => user.UserSongLikes)
                .ThenInclude(usl => usl.Song)
                .FirstOrDefaultAsync(user => user.Id == userId);

            var songs = user.UserSongLikes
                .Select(user => user.Song)
                .ToList();

            return View(songs);
        }

        [Route("Library/Liked/Albums")]
        public async Task<IActionResult> LikedAlbums()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users
                .Include(user => user.UserAlbumLikes)
                .ThenInclude(ual => ual.Album)
                .ThenInclude(album => album.Artist)
                .FirstOrDefaultAsync(user => user.Id == userId);

            var albums = user.UserAlbumLikes
                .Select(user => user.Album)
                .ToList();

            return View(albums);
        }

        [Route("Library/Liked/Artists")]
        public async Task<IActionResult> LikedArtists()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users
                .Include(user => user.UserArtistLikes)
                .ThenInclude(ual => ual.Artist)
                .FirstOrDefaultAsync(user => user.Id == userId);

            var artists = user.UserArtistLikes
                .Select(user => user.Artist)
                .ToList();

            return View(artists);
        }

        [Route("Library/Liked/Playlists")]
        public async Task<IActionResult> LikedPlaylists()
        {
            int userId = int.Parse(User.Identity.Name);
            var user = await this._context.Users
                .Include(user => user.UserPlaylistLikes)
                    .ThenInclude(ual => ual.Playlist)
                    .ThenInclude(upl => upl.User)
                .FirstOrDefaultAsync(user => user.Id == userId);

            var playlists = user.UserPlaylistLikes
                .Select(user => user.Playlist)
                .ToList();

            return View(playlists);
        }

    }
}
