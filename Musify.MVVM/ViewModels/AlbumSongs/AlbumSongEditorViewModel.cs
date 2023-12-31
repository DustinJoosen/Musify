﻿using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using Musify.MVVM.Views.Confirmation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels {

    public class AlbumSongEditorViewModel : NotifyPropertyChanged
    {
        // Fields.
        private Guid Id;

        // Commands.
        public ICommand OnAddSong { get; set; }
        public ICommand OnDeleteSong { get; set; }
        public ICommand OnClose { get; set; }

        // Properties.
        private Song _comboboxSelectedSong;
        public Song ComboboxSelectedSong
        {
            get => this._comboboxSelectedSong;
            set
            {
                this._comboboxSelectedSong = value;
                RaisePropertyChanged(nameof(ComboboxSelectedSong));
            }
        }

        public ObservableCollection<Song> UsedSongs { get; set; } = new();
        public ObservableCollection<Song> UnusedSongs { get; set; } = new();

        public Album Album { get; set; }

        // Express-properties. 
        public string AlbumName => Album.Title;

        public AlbumSongEditorViewModel(Guid albumId, Action<object> callback)
        {
            this.Id = albumId;
            this.Album = JsonHandler.GetById<Album>(albumId);

            this.OnAddSong = new RelayCommand(AddSong);
            this.OnDeleteSong = new RelayCommand((obj) => { });
            this.OnClose = new RelayCommand(callback);

            this.Refresh();
        }

        public void AddSong(object parameter)
        {
            if (!(parameter is Song song))
            {
                return;
            }

            // Link the song and album
            JsonHandler.Add<AlbumSong>(new()
            {
                albumId = this.Id,
                songId = song.Id
            });

            // Refresh the UI
            this.Refresh();
        }

        public void RemoveSong(object parameter)
        {
            Guid songId = (Guid)parameter;

            new RemoveSongFromAlbumConfirmationWindow(songId, (obj) =>
            {
                // Get the albumsongs WITHOUT the selected combo.
                var albumssongs = JsonHandler.GetAll<AlbumSong>();
                var filteredAlbumsongs = (from albumsong in albumssongs
                                          where albumsong.songId != songId || albumsong.albumId != this.Id
                                          select albumsong).ToList();

                // Save the albumsongs back again.
                JsonHandler.SaveAll<AlbumSong>(filteredAlbumsongs);

                // Refresh the UI
                this.Refresh();

            }).Show();
        }

        public void Refresh()
        {
            // First empty the lists.
            this.UsedSongs.Clear();
            this.UnusedSongs.Clear();

            // Get all song's in the album
            var songsInAlbum = JsonHandler.GetAll<AlbumSong>()
                .Where(albumsong => albumsong.albumId == this.Id)
                .Select(albumsong => JsonHandler.GetById<Song>(albumsong.songId))
                .ToList();

            // Add all songs to the datagrid.
            foreach (var song in songsInAlbum)
            {
                this.UsedSongs.Add(song);
            }

            // Get all songs that are NOT in the album.
            var songsNotInAlbum = JsonHandler.GetAll<Song>()
                .Where(song => !songsInAlbum.Any(s => s.Id == song.Id))
                .ToList();

            // Add all songs to the combobox.
            foreach (var song in songsNotInAlbum)
            {
                this.UnusedSongs.Add(song);
            }

            // Set first item in combobox
            if (this.UnusedSongs.Any())
            {
                this.ComboboxSelectedSong = this.UnusedSongs?.First();
            }
            
        }

    }
}