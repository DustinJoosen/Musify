using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels.Songs
{
    public class AlbumDeleteViewModel : NotifyPropertyChanged
    {
        // Fields.
        private readonly Guid _albumId;
        public string ImageSource => ImageHandler.GetFullFilePath(Album.CoverImage);
        public string Headline => $"Delete album [{this.Album?.Title}]";

        // Commands.
        public ICommand OnDelete { get; set; }
        public ICommand OnBack { get; set; }

        // Delegate actions.
        private Action<object> _goBackToAlbums;
        
        // Properties.
        private Album _album;
        public Album Album
        {
            get => this._album;
            set
            {
                this._album = value;
                RaisePropertyChanged(nameof(Album));
                RaisePropertyChanged(nameof(Headline));
            }
        }

        private ObservableCollection<Song> _songs = new();
        public ObservableCollection<Song> Songs
        {
            get => this._songs;
            set
            {
                this._songs = value;
                RaisePropertyChanged(nameof(Songs));
            }
        }

        private Visibility _listBoxVisible;
        public Visibility ListBoxVisible
        {
            get => this._listBoxVisible;
            set => this._listBoxVisible = value;
        }

        public AlbumDeleteViewModel(Guid albumId, Action<object> goBackToAlbums)
        {
            this._albumId = albumId;
            this._goBackToAlbums = goBackToAlbums;

            this.OnDelete = new RelayCommand(DeleteAlbum);
            this.OnBack = new RelayCommand(goBackToAlbums);

            this.Refresh();
        }

        public void Refresh()
        {
            this.Album = JsonHandler.GetById<Album>(this._albumId);

            // Get all song Id's.
            var songIds = JsonHandler.GetAll<AlbumSong>()
                .Where(albumsong => albumsong.albumId == this._albumId)
                .Select(albumsong => albumsong.songId)
                .ToList();

            this.ListBoxVisible = (songIds.Any()) ? Visibility.Visible : Visibility.Hidden;

            this.Songs.Clear();

            // Add all songs.
            foreach (Guid songId in songIds)
            {
                var song = JsonHandler.GetById<Song>(songId);
                this.Songs.Add(song);
            }
        }

        public void DeleteAlbum(object obj)
        {
            // Delete album.
            bool succeeded = JsonHandler.Delete<Album>(this._albumId);

            // Delete links between albums and songs.
            var albumsongs = JsonHandler.GetAll<AlbumSong>();
            var filteredAlbumSongs = albumsongs
                .Where(albumsong => albumsong.albumId != this._albumId)
                .ToList();

            succeeded = succeeded && JsonHandler.SaveAll<AlbumSong>(filteredAlbumSongs);

            // Remove the image (if any)
            ImageHandler.AttemptToDeleteImage(this.Album.CoverImage);

            // Let user know, and if succeeded send them back.
            if (!succeeded)
            {
                MessageBox.Show("Something went wrong. Please try again.");
                return;
            }
            
            MessageBox.Show("Successfully deleted album.");
            this._goBackToAlbums?.Invoke(obj);
        }
    }
}