using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.Services;

namespace Musify.MVC.Components
{
    [Authorize]
    public class ExploreListViewComponent : ViewComponent
    {
        private int _userId;
        
        private ApplicationDbContext _context;
        private ILikeService<Song> _songLikeService;
        private ILikeService<Album> _albumLikeService;

        public ExploreListViewComponent(ApplicationDbContext context, ILikeService<Song> songLikeService,
            ILikeService<Album> albumLikeService)
        {
            this._context = context;
            this._songLikeService = songLikeService;
            this._albumLikeService = albumLikeService;
        }

        public async Task<IViewComponentResult> InvokeAsync(SearchType searchType, string searchText=null)
        {
            this._userId = int.Parse(User.Identity.Name);

            switch (searchType)
            {
                case SearchType.Albums:
                    var albums = await this.GetAlbums(searchText);
                    return View("albumExplore", albums);
                case SearchType.Artists:
                    List<Artist> artists = await this.GetArtists(searchText);
                    return View("artistExplore", artists);
                case SearchType.Playlists:
                    List<Playlist> playlists = await this.GetPlaylists(searchText);
                    return View("playlistExplore", playlists);
                default:
                    var songs = await this.GetSongs(searchText);
                    return View("songExplore", songs);
            }
        }

        private async Task<List<DisplayedSongDto>> GetSongs(string searchText="")
        {
            return await this._context.Songs
                .Where(song => string.IsNullOrWhiteSpace(searchText) || song.Title.Contains(searchText))
                .Include(song => song.Artist)
                .Select(song => new DisplayedSongDto()
                {
                    Id = song.Id,
                    SongTitle = song.Title,
                    Artist = song.Artist.Name,
                    SongDuration = song.FormattedDuration,
                    Liked = this._songLikeService.IsLiked(this._userId, song.Id)
                })
                .ToListAsync();
        }

        private async Task<List<DisplayedAlbumDto>> GetAlbums(string searchText="")
        {
            return await this._context.Album
                .Where(album => string.IsNullOrWhiteSpace(searchText) || album.Title.Contains(searchText))
                .Include(album => album.Artist)
                .Select(album => new DisplayedAlbumDto()
                {
                    Id = album.Id,
                    Title = album.Title,
                    CoverImage = album.CoverImage,
                    ArtistName = album.Artist.Name,
                    Genre = album.Genre,
                    Liked = this._albumLikeService.IsLiked(this._userId, album.Id)
                })
                .ToListAsync();
        }

        private async Task<List<Artist>> GetArtists(string searchText = "")
        {
            return await this._context.Artists
                .Where(artist => string.IsNullOrEmpty(searchText) || artist.Name.Contains(searchText))
                .ToListAsync();
        }

        private async Task<List<Playlist>> GetPlaylists(string searchText = "")
        {
            return await this._context.Playlists
                .Where(playlist => playlist.IsPublic || playlist.UserId == int.Parse(User.Identity.Name))
                .Where(playlist => string.IsNullOrWhiteSpace(searchText) || playlist.Title.Contains(searchText))
                .Include(playlist => playlist.User)
                .ToListAsync();
        }
    }
}
