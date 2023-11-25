using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels 
{

    public class RemoveAlbumFromSongConfirmationViewModel
    {
        public ICommand DeleteAlbumFromSong { get; set; }
        public ICommand CloseWindow { get; set; }

        private Album _album = new();
        public Album Album
        {
            get => this._album;
            set => this._album = value;
        }

        public RemoveAlbumFromSongConfirmationViewModel(Guid albumId, Action<object> onDeleteConfirmation, Action<object> onCloseWindow)
        {
            this.Album = JsonHandler.GetById<Album>(albumId);
            
            this.DeleteAlbumFromSong = new RelayCommand((obj) =>
            {
                onDeleteConfirmation.Invoke(obj);
                onCloseWindow.Invoke(obj);
            });

            this.CloseWindow = new RelayCommand(onCloseWindow, (obj) => true);
        }
    }
}