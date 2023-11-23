using Microsoft.Win32;
using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.ViewModels.Albums
{
    internal class AlbumUpdateViewModel : Album
    {
        public ICommand OnUpdateAlbum { get; set; }
        public ICommand OnSelectImage { get; set; }
        public ICommand OnCancel { get; set; }

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

        private readonly string _originalCoverImagePath;

        private Guid _id;

        private Action<object> _goBack;

        public AlbumUpdateViewModel(Guid id, Action<object> goBack)
        {
            this._id = id;

            this.OnSelectImage = new RelayCommand(SelectImage);
            this.OnUpdateAlbum = new RelayCommand(UpdateAlbum);
            this.OnCancel = new RelayCommand(goBack);

            this._goBack = goBack;

            var album = JsonHandler.GetById<Album>(id);
            this.Title = album.Title;
            this.CoverImage = album.CoverImage;
            this._originalCoverImagePath = album.CoverImage;
            this.ReleaseYear = album.ReleaseYear;

            this.ImgCoverPreview = $"../../Lib/Uploads/{this.CoverImage}";
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

        public void UpdateAlbum(Object obj) 
        {
            // Updating image to lib.
            if (this._originalCoverImagePath != this.CoverImage)
            {
                try
                {
                    // Delete original
                    File.Delete($"../../../Lib/Uploads/{this._originalCoverImagePath}");

                    // Copies the file down to the local place.
                    this.CoverImage = Guid.NewGuid().ToString().Replace("-", "") + ".png";
                    File.Copy(this.ImgCoverPreview, $"../../../Lib/Uploads/{this.CoverImage}");
                } 
                catch (Exception ex)
                {
                    Console.WriteLine("Couldn't update image");
                    MessageBox.Show("Couldn't update image");
                    return;
                }
            }

            Boolean Success = JsonHandler.Update<Album>(_id, new Album()
            {
                Id = this._id,
                Title = this.Title,
                CoverImage = this.CoverImage,
                ReleaseYear = this.ReleaseYear,
            }); 
            if(Success)
            {
                MessageBox.Show("Succesfully updated the album");
                this._goBack?.Invoke(obj);
            } 
            
            else
            {
                MessageBox.Show("Update was not succesful, please try again");
            }
        }
    }
}
