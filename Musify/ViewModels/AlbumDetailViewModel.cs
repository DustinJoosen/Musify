using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.ViewModels {

    public class AlbumDetailViewModel : Album
    {
        public string DetailPageUnderline => $"{this.Artist} | {this.ReleaseYear}";
        public string FullImagePath => $"../../../Lib/Uploads/{this.CoverImage}";
        public string Artist => this.GetArtist();
        
        public AlbumDetailViewModel(Guid id)
        {
            this.Id = id;
            this.RetrieveAlbum();
        }

        // Retrieves the album out of the json, based on the Id property.
        public void RetrieveAlbum()
        {
            Task.Run(async () =>
            {
                // Get all albums.
                var albums = await JsonHandler.GetAll<Album>();
                if (albums == null)
                    return;

                // Select correct one.
                var selected = from alb in albums
                               where alb.Id.Equals(this.Id)
                               select alb;

                var album = selected?.FirstOrDefault() ?? new();

                // Assign values to this one.
                this.Title = album.Title;
                this.ReleaseYear = album.ReleaseYear;
                this.CoverImage = album.CoverImage;
                this.Songs = album.Songs;
            });
        }

        private string GetArtist()
        {
            var artists = this.Songs?.Select(artist => artist.Artist).Distinct().ToList();

            return (artists.Count() <= 1)
                ? artists.First()
                : "collaborated";

        }

    }
}