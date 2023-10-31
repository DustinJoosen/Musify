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
    public class AlbumViewModel : Album
    {
        public ICommand OnSaveAlbum { get; set; }
        public ICommand OnSelectImage { get; set; }
        
        private AlbumCreateWindow _window;
        private string _selectedCoverImagePath;

        public AlbumViewModel(AlbumCreateWindow window)
        {
            this._window = window;

            this.Title = "Cool Title";
            this.ReleaseYear = 2020;
            this.CoverImage = "notfound.png";

            this.OnSaveAlbum = new RelayCommand(SaveAlbum, (obj) => true);
            this.OnSelectImage = new RelayCommand(SelectImage, (obj) => true);
        }

        public async void SaveAlbum(object parameter)
        {
            if (Validation.GetHasError(this._window.txtTitle)
                || Validation.GetHasError(this._window.txtReleaseYr))
                return;

            // If no image browsed, use notfound.png
            if (string.IsNullOrEmpty(this._selectedCoverImagePath))
            {
                this.CoverImage = "notfound.png";
            }
            else
            {
                // Determine the cover filename (UUID)
                this.CoverImage = Guid.NewGuid().ToString().Replace("-", "") + ".png";

                // Copies the file down to the local placing.
                File.Copy(this._selectedCoverImagePath, $"../../../Lib/Uploads/{this.CoverImage}");
            }

            // Add the album.
            await JsonHandler.Add<Album>(new()
            {
                Title = this.Title,
                ReleaseYear = this.ReleaseYear,
                CoverImage = this.CoverImage
            });

            MessageBox.Show($"Successfully added album ({this.Title})");
            this.Reset();
        }

        public async void SelectImage(object parameter)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            // Select image.
            if (dialog.ShowDialog() == false)
            {
                return;
            }

            // Display the image in the preview
            this._window.imgCoverPreview.Source = new BitmapImage(new Uri(dialog.FileName));

            // Sets filename.
            this._selectedCoverImagePath = dialog.FileName;
            this.CoverImage = dialog.FileName;
        }

        public void Reset()
        {
            this.ReleaseYear = 0;
            this.Title = "";
            this.CoverImage = "";
            this._window.imgCoverPreview.Source = null;
        }
    }
}

