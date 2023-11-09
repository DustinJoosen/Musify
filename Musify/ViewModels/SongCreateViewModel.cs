using Microsoft.Win32;
using Musify.Models;
using Musify.Utility;
using Musify.Views.Albums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Musify.ViewModels
{
    public class SongCreateViewModel : Song, IDataErrorInfo
    {
        public ICommand OnSaveSong { get; set; }

        // Ensure numbers remain positive.  
        private int _durationMinutes = 0;
        public int DurationMinutes
        {
            get => this._durationMinutes;
            set => this._durationMinutes = Math.Abs(value);
        }

        // Ensure numbers remain positive.
        private int _durationSeconds = 0;
        public int DurationSeconds
        {
            get => this._durationSeconds;
            set => this._durationSeconds = Math.Abs(value);
        }

        public SongCreateViewModel()
        {
            this.ReleaseDate = DateTime.Today.AddDays(-1);
            this.OnSaveSong = new RelayCommand(SaveSong, (obj) => true);
        }

        public void SaveSong(object parameter)
        {
            // Calculate duration (04:58 => 298)
            int duration = (this.DurationMinutes * 60) + this.DurationSeconds;

            // Add the song.
            bool succeeded = JsonHandler.Add<Song>(new()
            {
                Title = this.Title,
                Artist = this.Artist,
                Genre = this.Genre,
                ReleaseDate = this.ReleaseDate,
                Duration = duration
            });

            if (succeeded)
            {
                MessageBox.Show($"Successfully added album ({this.Title})");
                this.Reset();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }

        public void Reset()
        {
            this.Title = string.Empty;
            this.Artist = string.Empty;
            this.Genre = string.Empty;
            this.ReleaseDate = DateTime.Today;
            this.Duration = 0;
        }

        #region DataValidation
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Title) && string.IsNullOrEmpty(Title))
                    return "Please enter a Title";

                if (columnName == nameof(Artist) && string.IsNullOrEmpty(Artist))
                    return "Please enter an Artist";

                if (columnName == nameof(Genre) && string.IsNullOrEmpty(Genre))
                    return "Please enter a Genre";

                if (columnName == nameof(ReleaseDate) && ReleaseDate.Date > DateTime.Today)
                    return "Release date can't be in the future";

                return string.Empty;
            }
        }

        public string Error => string.Empty;
        #endregion


    }
}

