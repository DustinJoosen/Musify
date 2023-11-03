using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.ViewModels
{
    public class SongDetailViewModel : Song
    {
        public string FormattedDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(this.Duration);
                return $"{time.ToString(@"mm\:ss")}";
            }
        }

        public SongDetailViewModel(Guid id)
        {
            this.Id = id;
            this.RetrieveSong();
        }

        public void RetrieveSong()
        {
            // Run this asynchronous
            Task.Run(async () =>
            {
                // Get all songs.
                var songs = await JsonHandler.GetAll<Song>();
                if (songs == null)
                    return;

                // Select correct one.
                var song = (from s in songs
                            where s.Id.Equals(this.Id)
                            select s).FirstOrDefault();

                // Assign values to this one.
                this.Title = song.Title;
                this.Artist = song.Artist;
                this.Genre = song.Genre;
                this.ReleaseDate = song.ReleaseDate;
                this.Duration = song.Duration;
                this.Albums = song.Albums;
            });

        }
    }
}