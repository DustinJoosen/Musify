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
    public class SongSearchFilterViewModel : NotifyPropertyChanged
    {

        private ObservableCollection<string> _artists;
        public ObservableCollection<string> Artists
        {
            get => this._artists;
            set
            {
                this._artists = value;
                RaisePropertyChanged(nameof(Artists));
            }
        }

        private static string _selectedArtist = "-";
        public string SelectedArtist
        {
            get => _selectedArtist;
            set
            {
                _selectedArtist = value;
                RaisePropertyChanged(nameof(SelectedArtist));

                this.Callback?.Invoke();
            }
        }

        private ObservableCollection<string> _genres;
        public ObservableCollection<string> Genres
        {
            get => this._genres;
            set
            {
                this._genres = value;
                RaisePropertyChanged(nameof(Genres));
            }
        }

        private static string _selectedGenre = "-";
        public string SelectedGenre
        {
            get => _selectedGenre;
            set
            {
                _selectedGenre = value;
                RaisePropertyChanged(nameof(SelectedGenre));

                this.Callback?.Invoke();
            }
        }


        public Action Callback { get; set; }

        public SongSearchFilterViewModel(Action callback)
        {
            this.Callback = callback;

            // Get all songs, and select all distinct artists and genres.
            var songs = JsonHandler.GetAll<Song>();

            var artists = songs
                .Select(song => song.Artist)
                .Distinct()
                .ToList();

            var genres = songs
                .Select(song => song.Genre)
                .Distinct()
                .ToList();

            // Adds the lists.
            artists.Insert(0, "-");
            genres.Insert(0, "-");

            this.Artists = new(artists);
            this.Genres = new(genres);
        }

        public void ApplyFilters(ref List<Song> songs)
        {
            if (this.SelectedArtist != "-")
            {
                songs = songs
                    .Where(song => song.Artist == this.SelectedArtist)
                    .ToList();
            }

            if (this.SelectedGenre != "-")
            {
                songs = songs
                    .Where(song => song.Genre == this.SelectedGenre)
                    .ToList();
            }
        }

    }
}
