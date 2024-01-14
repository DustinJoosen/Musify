using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.Services;
using Musify.MVC.ViewModels;

namespace Musify.MVC.Components
{
    [Authorize]
    public class ExploreListViewComponent : ViewComponent
    {
        private User _user;
        
        private ApplicationDbContext _context;
        private ILikeService<Song> _songLikeService;
        private ILikeService<Album> _albumLikeService;
        private ILikeService<Artist> _artistLikeService;
        private ILikeService<Playlist> _playlistLikeService;

        public ExploreListViewComponent(ApplicationDbContext context, ILikeService<Song> songLikeService,
            ILikeService<Album> albumLikeService, ILikeService<Artist> artistLikeService, ILikeService<Playlist> playlistLikeService)
        {
            this._context = context;
            this._songLikeService = songLikeService;
            this._albumLikeService = albumLikeService;
            this._artistLikeService = artistLikeService;
            this._playlistLikeService = playlistLikeService;
        }

        public async Task<IViewComponentResult> InvokeAsync(SearchType searchType, string searchText=null)
        {
            var _userId = int.Parse(User.Identity.Name);
            this._user = await this._context.Users.FindAsync(_userId);

            switch (searchType)
            {
                case SearchType.Albums:
                    var albums = await this.GetAlbums(searchText);
                    return View("albumExplore", albums);
                case SearchType.Artists:
                    var artists = await this.GetArtists(searchText);
                    return View("artistExplore", artists);
                case SearchType.Playlists:
                    var playlists = await this.GetPlaylists(searchText);
                    return View("playlistExplore", playlists);
                default:
                    var songs = await this.GetSongs(searchText);
                    return View("songExplore", songs);
            }
        }

        private async Task<List<SongViewModel>> GetSongs(string searchText="")
        {
            return await this._context.Songs
                .Where(song => string.IsNullOrWhiteSpace(searchText) || song.Title.Contains(searchText))
                .Include(song => song.Artist)
                .Select(song => new SongViewModel()
                {
                    Id = song.Id,
                    Title = song.Title,
                    ArtistName = song.Artist.Name,
                    Duration = song.Duration,
                    Liked = this._songLikeService.IsLiked(this._user.Id, song.Id)
                })
                .ToListAsync();
        }

        private async Task<List<AlbumViewModel>> GetAlbums(string searchText="")
        {
            return await this._context.Album
                .Where(album => string.IsNullOrWhiteSpace(searchText) || album.Title.Contains(searchText))
                .Include(album => album.Artist)
                .Include(album => album.AlbumSongs)
                    .ThenInclude(als => als.Song)
                .Select(album => new AlbumViewModel()
                {
                    Id = album.Id,
                    Title = album.Title,
                    CoverImage = album.CoverImage,
                    ArtistName = album.Artist.Name,
                    Genre = album.Genre,
                    Songs = album.AlbumSongs.Select(album => album.Song),
                    Liked = this._albumLikeService.IsLiked(this._user.Id, album.Id)
                })
                .ToListAsync();
        }

        private async Task<List<ArtistViewModel>> GetArtists(string searchText = "")
        {
            return await this._context.Artists
                .Where(artist => string.IsNullOrEmpty(searchText) || artist.Name.Contains(searchText))
                .Select(artist => new ArtistViewModel()
                {
                    Id = artist.Id,
                    Name = artist.Name,
                    Genre = artist.Genre,
                    Liked = this._artistLikeService.IsLiked(this._user.Id, artist.Id)
                })
                .ToListAsync();
        }

        private async Task<List<PlaylistViewModel>> GetPlaylists(string searchText = "")
        {
            return await this._context.Playlists
                .Where(playlist => playlist.IsPublic || playlist.UserId == int.Parse(User.Identity.Name))
                .Where(playlist => string.IsNullOrWhiteSpace(searchText) || playlist.Title.Contains(searchText))
                .Include(playlist => playlist.User)
                .Include(playlist => playlist.PlaylistSongs)
                    .ThenInclude(pls => pls.Song)
                .Select(playlist => new PlaylistViewModel
                {
                    Id = playlist.Id,
                    Title = playlist.Title,
                    Username = playlist.User.Name,
                    Songs = playlist.PlaylistSongs.Select(playlist => playlist.Song),
                    Liked = this._playlistLikeService.IsLiked(this._user.Id, playlist.Id)
                })
                .OrderByDescending(playlist => playlist.Username == this._user.Name)
                .ThenBy(playlist => playlist.Title)
                .ToListAsync();
        }
    }
}
