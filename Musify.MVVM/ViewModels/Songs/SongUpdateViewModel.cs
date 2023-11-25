using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using Musify.MVVM.Views.Confirmation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels.Songs
{
    public class SongUpdateViewModel : Song, IDataErrorInfo
    {
        // Fields.
        private Guid _id;

        // Commands.
        public ICommand OnUpdateSong { get; set; }
        public ICommand OnCancel { get; set; }

        // Delegate actions.
        private Action<object> _goBackToSongs;

        // Properties.
        private int _durationMinutes = 0;
        public int DurationMinutes
        {
            get => this._durationMinutes;
            set => this._durationMinutes = Math.Abs(value); // Ensure numbers remain positive.
        }

        private int _durationSeconds = 0;
        public int DurationSeconds
        {
            get => this._durationSeconds;
            set => this._durationSeconds = Math.Abs(value);  // Ensure numbers remain positive.
        }

        public SongUpdateViewModel(Guid id, Action<object> goBackToSongs) 
        {
            this._id = id;
            this._goBackToSongs = goBackToSongs;

            this.OnUpdateSong = new RelayCommand(UpdateSong);
            this.OnCancel = new RelayCommand(goBackToSongs);

            var song = JsonHandler.GetById<Song>(id);
            this.Id = song.Id;
            this.Title = song.Title;
            this.Artist = song.Artist;
            this.Genre = song.Genre;
            this.ReleaseDate = song.ReleaseDate;
            this.Duration = song.Duration;

            this.DurationMinutes = this.Duration / 60;
            this.DurationSeconds = this.Duration % 60;
        }

        public void UpdateSong(Object obj) 
        {
            // Calculate duration (04:58 => 298)
            int duration = (this.DurationMinutes * 60) + this.DurationSeconds;

            var newSong = new Song()
            {
                Id = this._id,
                Title = this.Title,
                Artist = this.Artist,
                Genre = this.Genre,
                ReleaseDate = this.ReleaseDate,
                Duration = duration,
            };

            var confirmation = new UpdateSongConfirmationWindow(newSong.Id, newSong, onUpdate: ProcessUpdateSong);
            confirmation.Show();        
        }

        public void ProcessUpdateSong(object obj)
        {
            if (!(obj is Song song))
            {
                return;
            }

            bool success = JsonHandler.Update<Song>(this.Id, song);
            if (success)
            {
                MessageBox.Show("Succesfully updated the song");
                this._goBackToSongs?.Invoke(obj);
            }
            else
            {
                MessageBox.Show("Update was not succesful, please try again");
            }
        }

        #region DataValidation
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Title) && string.IsNullOrWhiteSpace(Title))
                    return "Please enter a Title";
                if (columnName == nameof(Artist) && string.IsNullOrWhiteSpace(Artist))
                    return "Please enter a Artist";
                if (columnName == nameof(Genre) && string.IsNullOrWhiteSpace(Genre))
                    return "Please enter a Genre";
                if (columnName == nameof(DurationSeconds) && DurationSeconds >= 60)
                    return "Seconds can't be more then 60";
                if (columnName == nameof(DurationMinutes) && DurationMinutes >= 60)
                    return "Minutes can't be more then 60";

                return string.Empty;
            }
        }

        public string Error => string.Empty;

        #endregion

    }
}
