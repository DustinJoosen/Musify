using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels.Songs
{
    public class SongDeleteViewModel : NotifyPropertyChanged
    {
        public ICommand OnDelete { get; set; }
        public ICommand OnBack { get; set; }

        private Action<object> _goBackToSongs;

        private Song _song;
        public Song Song
        {
            get => this._song;
            set
            {
                this._song = value;
                RaisePropertyChanged(nameof(Song));
                RaisePropertyChanged(nameof(Headline));
            }
        }

        private ObservableCollection<Album> _albums = new();
        public ObservableCollection<Album> Albums
        {
            get => this._albums;
            set
            {
                this._albums = value;
                RaisePropertyChanged(nameof(Songs));
            }
        }

        private Visibility _listBoxVisible;
        public Visibility ListBoxVisible
        {
            get => this._listBoxVisible;
            set => this._listBoxVisible = value;
        }

        public string Headline => $"Delete song [{this.Song?.Title}]";

        private readonly Guid _songId;

        public SongDeleteViewModel(Guid songId, Action<object> goBackToSongs)
        {
            this._songId = songId;
            this._goBackToSongs = goBackToSongs;

            this.OnDelete = new RelayCommand(DeleteSong);
            this.OnBack = new RelayCommand(goBackToSongs);

            this.Refresh();
        }

        public void Refresh()
        {
            this.Song = JsonHandler.GetById<Song>(this._songId);

            // Get all album Id's.
            var albumIds = JsonHandler.GetAll<AlbumSong>()
                .Where(albumsong => albumsong.songId == this._songId)
                .Select(albumsong => albumsong.albumId)
                .ToList();

            this.ListBoxVisible = (albumIds.Any()) ? Visibility.Visible : Visibility.Hidden;

            this.Albums.Clear();

            // Add all albums.
            foreach (Guid albumId in albumIds)
            {
                var album = JsonHandler.GetById<Album>(albumId);
                this.Albums.Add(album);
            }
        }

        public void DeleteSong(object obj)
        {
            // Delete song.
            bool succeeded = JsonHandler.Delete<Song>(this._songId);

            // Delete links between albums and songs.
            var albumsongs = JsonHandler.GetAll<AlbumSong>();
            var filteredAlbumSongs = albumsongs
                .Where(albumsong => albumsong.songId != this._songId)
                .ToList();

            succeeded = succeeded && JsonHandler.SaveAll<AlbumSong>(filteredAlbumSongs);

            // Let user know, and if succeeded send them back.
            if (!succeeded)
            {
                MessageBox.Show("Something went wrong. Please try again.");
                return;
            }
            
            MessageBox.Show("Successfully deleted song.");
            this._goBackToSongs?.Invoke(obj);
        }
    }
}