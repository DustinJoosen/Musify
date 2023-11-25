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

    public class UpdateSongConfirmationViewModel : Song
    {
        // Commands.
        public ICommand UpdateSong { get; set; }
        public ICommand CloseWindow { get; set; }

        // Properties.
        public string FormattedOldDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.OldSong.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }
        public string FormattedNewDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.NewSong.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }

        public Song OldSong { get; set; }
        public Song NewSong { get; set; }

        // Express-properties.

        public UpdateSongConfirmationViewModel(Guid songId, Song newSong, 
            Action<object> onUpdate, Action<object> onClose)
        {
            this.UpdateSong = new RelayCommand((obj) =>
            {
                onUpdate.Invoke(obj);
                onClose.Invoke(obj);
            });

            this.NewSong = newSong;
            this.OldSong = JsonHandler.GetById<Song>(songId);
            
            this.CloseWindow = new RelayCommand(onClose);
        }
    }
}