using Microsoft.Win32;
using Musify.Models;
using Musify.Utility;
using Musify.Views.Albums;
using System;
using System.Collections.Generic;
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
    public class SongCreateViewModel : Song
    {
        public ICommand OnSaveSong { get; set; }

        public SongCreateViewModel()
        {
            this.Title = "Cool Title";
            this.Artist = "NSP";
            this.Genre = "Pop";
            this.ReleaseDate = DateTime.Today;
            this.Duration = 420;

            this.OnSaveSong = new RelayCommand(SaveSong, (obj) => true);
        }

        public async void SaveSong(object parameter)
        {
            // Validation.
            if ((string.IsNullOrEmpty(this.Title) ||
                string.IsNullOrEmpty(this.Artist) ||
                string.IsNullOrEmpty(this.Genre)))
                return;

            // Add the song.
            await JsonHandler.Add<Song>(new()
            {
                Title = this.Title,
                Artist = this.Artist,
                Genre = this.Genre,
                ReleaseDate = this.ReleaseDate,
                Duration = this.Duration
            });

            MessageBox.Show($"Successfully added song ({this.Title})");
        }
    }
}

