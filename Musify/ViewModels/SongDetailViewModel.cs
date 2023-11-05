﻿using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Musify.ViewModels
{
    public class SongDetailViewModel : Song
    {

        public ObservableCollection<Album> Albums { get; set; } = new();

        public string FormattedDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }

        public SongDetailViewModel(Guid id)
        {
            this.Id = id;
            this.RetrieveSong();
            this.RetrieveAlbums();
        }

        public void RetrieveSong()
        {
            // Get all songs.
            var songs = JsonHandler.GetAll<Song>();
            if (songs == null)
                return;

            // Select correct one.
            var song = (from s in songs
                        where s.Id.Equals(this.Id)
                        select s).FirstOrDefault();

            // Assign values to this one.
            this.Title = song.Title;
            this.Artist = song.Artist;
            this.Genre = song.Genre;
            this.ReleaseDate = song.ReleaseDate;
            this.Duration = song.Duration;
        }

        public void RetrieveAlbums()
        {
            // Get all albumsongs.
            var albumsongs = JsonHandler.GetAll<AlbumSong>();
            if (albumsongs == null)
                return;

            // Select all album id's that match the song.
            var albumIds = from albumsong in albumsongs
                           where albumsong.songId.Equals(this.Id)
                           select albumsong.albumId;

            // Add all albums
            foreach (Guid albumId in albumIds)
            {
                var album = JsonHandler.GetById<Album>(albumId);
                this.Albums.Add(album);
            }
        }

    }
}