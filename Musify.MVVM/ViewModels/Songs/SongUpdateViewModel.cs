using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels.Songs
{
    public class SongUpdateViewModel : Song
    {
        public ICommand OnUpdateSong { get; set; }

        private Guid _id;

        public SongUpdateViewModel(Guid id) 
        {
            this._id = id;
            this.OnUpdateSong = new RelayCommand(UpdateSong);

            var song = JsonHandler.GetById<Song>(id);
            this.Title = song.Title;
            this.Artist = song.Artist;
            this.Genre = song.Genre;
            this.ReleaseDate = song.ReleaseDate;
            this.Duration = song.Duration;
        }

        public void UpdateSong(Object obj) 
        {
            Boolean Success = JsonHandler.Update<Song>(_id, new Song()
            {
                Id = this._id,
                Title = this.Title,
                Artist = this.Artist,
                Genre = this.Genre,
                ReleaseDate = this.ReleaseDate,
                Duration = this.Duration,
            });
        
            if(Success)
            {
                MessageBox.Show("Succesfully updated the song");
            } 
            
            else
            
            {
                MessageBox.Show("Update was not succesful, please try again");
            }
        }
    }
}
