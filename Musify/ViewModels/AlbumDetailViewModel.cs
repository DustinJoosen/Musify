using Musify.Models;
using Musify.Utility;
using Musify.Views.Albums;
using Musify.Views.AlbumSongs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Musify.ViewModels {

    public class AlbumDetailViewModel : Album
    {
        public ICommand GoToSongEdits { get; set; }

        public ObservableCollection<Song> Songs { get; set; } = new();

        // Useful props
        public string DetailPageUnderline => $"{this.Artist} | {this.ReleaseYear}";
        public string FullImagePath => $"../../../Lib/Uploads/{this.CoverImage}";
        public string Artist => this.GetArtist();
        
        public AlbumDetailViewModel(Guid id)
        {
            this.Id = id;

            // Show the screen when activating the command.
            this.GoToSongEdits = new RelayCommand((obj) =>
            {
                var albumSongsEditorWindow = new AlbumSongsEditorWindow(id);
                albumSongsEditorWindow.Callback += (obj) => this.RetrieveSongs();
                albumSongsEditorWindow.Show();
            });

            this.RetrieveAlbum();
            this.RetrieveSongs();
        }

        // Retrieves the album out of the json, based on the Id property.
        public void RetrieveAlbum()
        {
            // Get all albums.
            var albums = JsonHandler.GetAll<Album>();
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
        }

        public void RetrieveSongs()
        {
            this.Songs.Clear();

            // Get all albumsongs.
            var albumsongs = JsonHandler.GetAll<AlbumSong>();
            if (albumsongs == null)
                return;

            // Select all song id's that match the album
            var songIds = from albumsong in albumsongs
                          where albumsong.albumId.Equals(this.Id)
                          select albumsong.songId;

            // Add all songs
            foreach (Guid songId in songIds)
            {
                var song = JsonHandler.GetById<Song>(songId);
                this.Songs.Add(song);
            }
        }

        private string GetArtist()
        {
            var artists = this.Songs?.Select(artist => artist.Artist).Distinct().ToList();

            switch (artists?.Count())
            {
                case 0:
                    return "collaborated";
                case 1:
                    return artists?.First();
                default:
                    return "collablorated";
            }
        }

    }
}