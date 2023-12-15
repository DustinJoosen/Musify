using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Dtos;
using Musify.MVC.Models;

namespace Musify.MVC.Components
{
    public class ExploreListViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;
        public ExploreListViewComponent(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(SearchType searchType, string searchText=null)
        {
            switch (searchType)
            {
                case SearchType.Albums:
                    List<Album> albums = await this.GetAlbums(searchText);
                    return View("albumExplore", albums);
                case SearchType.Artists:
                    List<Artist> artists = await this.GetArtists(searchText);
                    return View("artistExplore", artists);
                case SearchType.Playlists:
                    List<Playlist> playlists = await this.GetPlaylists(searchText);
                    return View("playlistExplore", playlists);
                default:
                    List<Song> songs = await this.GetSongs(searchText);
                    return View("songExplore", songs);
            }
        }

        private async Task<List<Song>> GetSongs(string searchText="")
        {
            return await this._context.Songs
                .Where(song => string.IsNullOrWhiteSpace(searchText) || song.Title.Contains(searchText))
                .Include(song => song.Artist)
                .ToListAsync();
        }

        private async Task<List<Album>> GetAlbums(string searchText="")
        {
            return await this._context.Album
                .Where(album => string.IsNullOrWhiteSpace(searchText) || album.Title.Contains(searchText))
                .Include(album => album.Artist)
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
