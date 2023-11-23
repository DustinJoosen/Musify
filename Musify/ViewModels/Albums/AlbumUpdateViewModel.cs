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
        public ICommand OnCancel { get; set; }


        private Guid _id;

        private Action<object> _goBack;

        public AlbumUpdateViewModel(Guid id, Action<object> goBack)
        {
            this._id = id;
            this.OnUpdateAlbum = new RelayCommand(UpdateAlbum);
            this.OnCancel = new RelayCommand(goBack);

            this._goBack = goBack;

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
                this._goBack?.Invoke(obj);
            } 
            
            else
            {
                MessageBox.Show("Update was not succesful, please try again");
            }
        }
    }
}
