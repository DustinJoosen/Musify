using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Musify.ViewModels
{
    public class AlbumViewModel : Album
    {
        public ICommand OnSaveAlbum { get; set; }

        public AlbumViewModel()
        {
            this.Title = "Cool Title";
            this.CoverImage = "notfound.png";

            this.OnSaveAlbum = new RelayCommand(SaveAlbum, (obj) => true);
        }

        public void SaveAlbum(object parameter)
        {
            this.Title = "Title is connected properly";
        }
    }
}