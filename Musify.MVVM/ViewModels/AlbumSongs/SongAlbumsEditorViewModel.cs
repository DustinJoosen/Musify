using Musify.MVVM.Models;
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

    public class SongAlbumsEditorViewModel : NotifyPropertyChanged
    {
        private Guid Id;

        public ICommand OnAddAlbum { get; set; }
        public ICommand OnDeleteAlbum { get; set; }
        public ICommand OnClose { get; set; }

        public ObservableCollection<Album> UsedAlbums { get; set; } = new();
        public ObservableCollection<Album> UnusedAlbums { get; set; } = new();

        private Album _comboboxSelectedAlbum;
        public Album ComboboxSelectedAlbum
        {
            get => this._comboboxSelectedAlbum;
            set
            {
                this._comboboxSelectedAlbum = value;
                RaisePropertyChanged(nameof(ComboboxSelectedAlbum));
            }
        }

        public Song Song { get; set; }
        public string SongName => Song.Title;

        public SongAlbumsEditorViewModel(Guid songId, Action<object> callback)
        {
            this.Id = songId;
            this.Song = JsonHandler.GetById<Song>(songId);

            this.OnAddAlbum = new RelayCommand(AddAlbum);
            this.OnClose = new RelayCommand(callback);

            this.Refresh();
        }

        public void AddAlbum(object parameter)
        {
            if (!(parameter is Album album))
            {
                return;
            }

            // Link the song and album
            JsonHandler.Add<AlbumSong>(new()
            {
                songId = this.Id,
                albumId = album.Id
            });

            // Refresh the UI
            this.Refresh();
        }

        public void RemoveAlbum(object parameter)
        {
            Guid albumId = (Guid)parameter;

            new RemoveAlbumFromSongConfirmationWindow(albumId, onDeleteConfirmation: (obj) =>
            {
                // Get all albumsongs WITHOUT the selected combo.
                var albumsongs = JsonHandler.GetAll<AlbumSong>();
                var filteredAlbumSongs = (from albumsong in albumsongs
                                          where albumsong.songId != this.Id || albumsong.albumId != albumId
                                          select albumsong).ToList();

                // Save the albumsongs back, but now without the selected combo.
                JsonHandler.SaveAll<AlbumSong>(filteredAlbumSongs);

                // Refresh the UI
                this.Refresh();
            }).Show();
        }

        public void Refresh()
        {
            // First empty the lists.
            this.UsedAlbums.Clear();
            this.UnusedAlbums.Clear();

            // Get all song's in the album
            var albumsInSong = JsonHandler.GetAll<AlbumSong>()
                .Where(albumsong => albumsong.songId == this.Id)
                .Select(albumsong => JsonHandler.GetById<Album>(albumsong.albumId))
                .ToList();

            // Add all songs to the datagrid.
            foreach (var album in albumsInSong)
            {
                this.UsedAlbums.Add(album);
            }

            // Get all songs that are NOT in the album.
            var albumsNotInSong = JsonHandler.GetAll<Album>()
                .Where(album => !albumsInSong.Any(albumInSong => albumInSong.Id == album.Id))
                .ToList();

            // Add all songs to the combobox.
            foreach (var album in albumsNotInSong)
            {
                this.UnusedAlbums.Add(album);
            }

            // Set first item in combobox
            if (this.UnusedAlbums.Any())
            {
                this.ComboboxSelectedAlbum = this.UnusedAlbums?.First();
            }
        }

    }
}