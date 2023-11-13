using Microsoft.Win32;
using Musify.Models;
using Musify.Utility;
using Musify.Views.Albums;
using Musify.Views.Confirmation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Musify.ViewModels {

    public class AlbumCreateViewModel : Album, IDataErrorInfo
    {
        // Commands
        public ICommand OnSaveAlbum { get; set; }
        public ICommand OnSelectImage { get; set; }
        public ICommand OnGoBack { get; set; }


        // Properties
        private string _imgCoverPreview;
        public string ImgCoverPreview
        {
            get => this._imgCoverPreview;
            set
            {
                this._imgCoverPreview = value;
                RaisePropertyChanged(nameof(ImgCoverPreview));
            }
        }

        public AlbumCreateViewModel(Action<object> goBack)
        {
            this.ReleaseYear = 1900;

            this.OnSaveAlbum = new RelayCommand(SaveAlbum);
            this.OnSelectImage = new RelayCommand(SelectImage);
            this.OnGoBack = new RelayCommand(goBack);
        }

        public void SaveAlbum(object parameter)
        {
            // If no image browsed, use notfound.png
            if (string.IsNullOrEmpty(this.ImgCoverPreview))
            {
                this.CoverImage = "notfound.png";
            }
            else
            {
                // Determine the cover filename (UUID)
                this.CoverImage = Guid.NewGuid().ToString().Replace("-", "") + ".png";

                // Copies the file down to the local placing.
                File.Copy(this.ImgCoverPreview, $"../../../Lib/Uploads/{this.CoverImage}");
            }

            // Add the album.
            bool succeeded = JsonHandler.Add<Album>(new()
            {
                Title = this.Title,
                ReleaseYear = this.ReleaseYear,
                CoverImage = this.CoverImage,
            });

            if (succeeded)
            {
                MessageBox.Show($"Successfully added album ({this.Title})");
                this.OnGoBack.Execute(null);
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again");
            }

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
            this.ImgCoverPreview = dialog.FileName;

            // Sets filename.
            this.CoverImage = dialog.FileName;
        }

        #region DataValidation
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Title) && string.IsNullOrEmpty(Title))
                    return "Please enter a Title";

                if (columnName == nameof(ReleaseYear) && ReleaseYear > DateTime.Today.Year)
                    return "Release date can't be in the future";

                return string.Empty;
            }
        }

        public string Error => string.Empty;

        #endregion

    }
}