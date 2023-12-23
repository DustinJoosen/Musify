using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models;

namespace Musify.MVC.Services.SongSuggest
{
    public class SongSuggestService : ISongSuggestService
    {
        private ApplicationDbContext _context;
        public SongSuggestService(ApplicationDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// A list of Song objects, that are not in basedOn and either have a matching artist or a matching album.
        /// </summary>
        /// <param name="numberOfSongs"></param>
        /// <param name="basedOn"></param>
        /// <returns>A list of Song objects, of size numberOfSongs</returns>
        public IEnumerable<Song> PickSuggestedSongs(int numberOfSongs, IEnumerable<Song> basedOn)
        {
            var songs = this._context.Songs
                .Include(s => s.AlbumSongs)
                .Where(song => !basedOn.Contains(song));

            var matchingArtists = songs
                .Where(song => basedOn.Select(bs => bs.ArtistId).Contains(song.ArtistId))
                .ToList();

            var matchingAlbums = songs
                .AsEnumerable()
                .Where(song => DoesSongAppearInAlbumFromSource(basedOn, song))
                .ToList();

            return matchingArtists.Union(matchingAlbums)
                .OrderBy(num => Guid.NewGuid())
                .Take(numberOfSongs)
                .ToList();
        }

        private bool DoesSongAppearInAlbumFromSource(IEnumerable<Song> source, Song song)
        {
            var sourceAlbums = source
                .SelectMany(k => k.AlbumSongs)
                .Select(k => k.AlbumId)
                .ToList();

            var songAlbums = song.AlbumSongs
                .Select(s => s.AlbumId)
                .ToList();

            return sourceAlbums.Intersect(songAlbums).Any();
        }
    }
}
