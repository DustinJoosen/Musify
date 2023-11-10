using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
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
        private Guid _id;

        public AlbumUpdateViewModel(Guid id)
        {
            this._id = id;
            this.OnUpdateAlbum = new RelayCommand(UpdateAlbum);
            
            var album = JsonHandler.GetById<Album>(id);
            this.Title = album.Title;
            this.CoverImage = album.CoverImage;
            this.ReleaseYear = album.ReleaseYear;
        }

        public void UpdateAlbum(Object obj) 
        {
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
            } 
            
            else
            
            {
                MessageBox.Show("Update was not succesful, please try again");
            }
        }
    }
}
