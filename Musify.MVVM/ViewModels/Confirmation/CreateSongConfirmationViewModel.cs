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

    public class CreateSongConfirmationViewModel : Song
    {
        // Commands.
        public ICommand CreateSong { get; set; }
        public ICommand CloseWindow { get; set; }

        // Properties.
        public string FormattedDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }

        public CreateSongConfirmationViewModel(Song song, Action<object> onCreate, Action<object> onCloseWindow)
        {
            this.Title = song.Title;
            this.Artist = song.Artist;
            this.Genre = song.Genre;
            this.ReleaseDate = song.ReleaseDate;
            this.Duration = song.Duration;

            this.CreateSong = new RelayCommand((obj) =>
            {
                onCreate.Invoke(obj);
                onCloseWindow.Invoke(obj);
            });

            this.CloseWindow = new RelayCommand(onCloseWindow, (obj) => true);
        }
    }
}