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

    public class RemoveSongFromAlbumConfirmationViewModel
    {
        // Commands.
        public ICommand DeleteSongFromAlbum { get; set; }
        public ICommand CloseWindow { get; set; }

        // Properties.
        private Song _song = new();
        public Song Song
        {
            get => this._song;
            set => this._song = value;
        }

        // Express-properties.
        public string SongUnderline => this.Song.Artist + " | " + this.Song.ReleaseDate.ToString("dd/MM/yyyy");

        public RemoveSongFromAlbumConfirmationViewModel(Guid songId, Action<object> onDeleteConfirmation, 
            Action<object> onCloseWindow)
        {
            this.Song = JsonHandler.GetById<Song>(songId);
            
            this.DeleteSongFromAlbum = new RelayCommand((obj) =>
            {
                onDeleteConfirmation.Invoke(obj);
                onCloseWindow.Invoke(obj);
            });

            this.CloseWindow = new RelayCommand(onCloseWindow, (obj) => true);
        }
    }
}