﻿using Microsoft.Win32;
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
        // Commands
        public ICommand OnSaveAlbum { get; set; }
        public ICommand OnSelectImage { get; set; }


        // Full Properties
        private AlbumCreateWindow _createWindow;
        public AlbumCreateWindow CreateWindow
        {
            get => this._createWindow;
            set => this._createWindow = value;
        }

        private Guid _id;
        public Guid Id
        {
            get => this._id;
            set => this._id = value;
        }

        public Album Album
        {
            set
            {
                this.Title = value.Title;
                this.ReleaseYear = value.ReleaseYear;
                this.CoverImage = value.CoverImage;
            }
        }

        // Useful fields
        private string _selectedCoverImagePath;


        // Methods
        public AlbumViewModel(Guid id = default)
        {
            if (id != default)
            {
                this.Id = id;
            }

            this.Title = "Cool Title";
            this.ReleaseYear = 2020;
            this.CoverImage = "notfound.png";

            this.OnSaveAlbum = new RelayCommand(SaveAlbum, (obj) => true);
            this.OnSelectImage = new RelayCommand(SelectImage, (obj) => true);
            this.RetrieveAlbum();
        }


        // Retrieves the album out of the json, based on the Id property.
        public void RetrieveAlbum()
        {
            Task.Run(async () =>
            {
                var albums = await JsonHandler.GetAll<Album>();
                if (albums == null)
                    return;

                var selected = from album in albums
                               where album.Id.Equals(this.Id)
                               select album;

                this.Album = selected?.FirstOrDefault() ?? new();

            });
        }

        public async void SaveAlbum(object parameter)
        {
            if (Validation.GetHasError(this.CreateWindow.txtTitle)
                || Validation.GetHasError(this.CreateWindow.txtReleaseYr))
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
            this.CreateWindow.imgCoverPreview.Source = new BitmapImage(new Uri(dialog.FileName));

            // Sets filename.
            this._selectedCoverImagePath = dialog.FileName;
            this.CoverImage = dialog.FileName;
        }

        public void Reset()
        {
            this.ReleaseYear = 0;
            this.Title = "";
            this.CoverImage = "";
            this.CreateWindow.imgCoverPreview.Source = null;
        }
    }
}
