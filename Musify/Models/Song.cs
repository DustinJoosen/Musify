using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.Models
{
    public class Song : NotifyPropertyChanged
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        private string _title;
        public string Title
        {
            get => this._title;
            set
            {
                this._title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private string _artist;
        public string Artist
        {
            get => this._artist;
            set
            {
                this._artist = value;
                RaisePropertyChanged(nameof(Artist));
            }
        }

        private string _genre;
        public string Genre
        {
            get => this._genre;
            set
            {
                this._genre = value;
                RaisePropertyChanged(nameof(Genre));
            }
        }


        private DateTime _releaseDate;
        public DateTime ReleaseDate
        {
            get => this._releaseDate;
            set
            {
                this._releaseDate = value;
                RaisePropertyChanged(nameof(ReleaseDate));
            }
        }

        private int _duration;
        public int Duration
        {
            get => this._duration;
            set
            {
                this._duration = value;
                RaisePropertyChanged(nameof(Duration));
            }
        }

        public List<Album> Albums { get; set; } = new();


        public override string ToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(this.Duration);
            return $"{time.ToString(@"mm\:ss")} | {this.Title}";
        }
    }
}